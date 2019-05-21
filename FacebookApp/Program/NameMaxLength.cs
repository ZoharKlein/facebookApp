namespace Program
{
    internal class NameMaxLength : INameFilterChain
    {
        public INameFilterChain NextInChain { get; private set; }

        public float MaxLengthName { get; private set; }

        public float CalculateNameLength(NameCalculator i_NameCalculator)
        {
            if (i_NameCalculator.CalculateRequest == eCalculateRequest.Max)
            {
                MaxLengthName = i_NameCalculator.UserNameList()[0].Length;

                foreach (string userName in i_NameCalculator.UserNameList())
                {
                    if (userName.Length > MaxLengthName)
                    {
                        MaxLengthName = userName.Length;
                    }
                }
            }
            else
            {
                MaxLengthName = this.NextInChain.CalculateNameLength(i_NameCalculator);
            }

            return MaxLengthName;
        }

        public void SetnextChain(INameFilterChain i_NextChain)
        {
            this.NextInChain = i_NextChain;
        }
    }
}
