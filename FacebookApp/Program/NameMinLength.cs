namespace Program
{
    internal class NameMinLength : INameFilterChain
    {
        public INameFilterChain NextInChain { get; private set; }

        public float MinLengthName { get; private set; }

        public float CalculateNameLength(NameCalculator i_NameCalculator)
        {
            if (i_NameCalculator.CalculateRequest == eCalculateRequest.Min)
            {
                MinLengthName = i_NameCalculator.UserNameList()[0].Length;

                foreach (string userName in i_NameCalculator.UserNameList())
                {
                    if (userName.Length < MinLengthName)
                    {
                        MinLengthName = userName.Length;
                    }
                }
            }
            else
            {
                MinLengthName = this.NextInChain.CalculateNameLength(i_NameCalculator);
            }

            return MinLengthName;
        }

        public void SetnextChain(INameFilterChain i_NextChain)
        {
            this.NextInChain = i_NextChain;
        }
    }
}
