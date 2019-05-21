namespace Program
{
    internal class MinComparer : IComparer
    {
        public bool ShouldSwap(string i_Name1, string i_Name2)
        {
            return i_Name1.Length > i_Name2.Length;
        }
    }
}