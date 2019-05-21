using System.Linq;

namespace Program
{
    internal class NameAverageLength : INameFilterChain
    {
        public INameFilterChain NextInChain { get; private set; }

        public float AverageLengthName { get; private set; }

        public float CalculateNameLength(NameCalculator i_NameCalculator)
        {
            AverageLengthName = 0.0f;

            if(i_NameCalculator.CalculateRequest == eCalculateRequest.Average)
            {
                int countChars = 0;

                foreach (string userName in i_NameCalculator.UserNameList())
                {
                    countChars += userName.Length;
                }

                AverageLengthName = countChars / i_NameCalculator.UserNameList().Count();         
            }
            else
            {
                AverageLengthName = this.NextInChain.CalculateNameLength(i_NameCalculator);
            }

            return AverageLengthName;
        }

        public void SetnextChain(INameFilterChain i_NextChain)
        {
            this.NextInChain = i_NextChain;
        }
    }
}
