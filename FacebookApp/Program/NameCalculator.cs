using System.Collections.Generic;

namespace Program
{
    public class NameCalculator
    {
        private readonly List<string> r_UserNameList = new List<string>();

        public eCalculateRequest CalculateRequest { get; private set; }

        public NameCalculator(List<string> i_UserNameList, eCalculateRequest i_eCalculateRequest)
        {
            r_UserNameList = i_UserNameList;
            CalculateRequest = i_eCalculateRequest;
        }

        public List<string> UserNameList()
        {
            return r_UserNameList;
        }
    }
}
