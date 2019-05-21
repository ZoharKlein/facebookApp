namespace Program
{
    internal class AlphabetComparer : IComparer
    {
        public bool ShouldSwap(string i_Name1, string i_Name2)
        {
            return i_Name1[0] > i_Name2[0];
        }
    }
}
