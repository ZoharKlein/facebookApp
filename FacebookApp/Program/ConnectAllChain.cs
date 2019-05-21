using System.Collections.Generic;

namespace Program
{
    internal class ConnectAllChain
    {
        private INameFilterChain m_AvgChain = new NameAverageLength();
        private INameFilterChain m_MinChain = new NameMinLength();
        private INameFilterChain m_MaxChain = new NameMaxLength();

        public ConnectAllChain()
        {
            connectChain();
        }

        private void connectChain()
        {
            m_AvgChain.SetnextChain(m_MinChain);
            m_MinChain.SetnextChain(m_MaxChain);
        }

        public float SetAndCalcByUserChoice(List<string> i_UserNameList, eCalculateRequest i_eCalculateRequest)
        {
            NameCalculator nameCalculator = new NameCalculator(i_UserNameList, i_eCalculateRequest);

            return m_AvgChain.CalculateNameLength(nameCalculator);
        }
    }
}
