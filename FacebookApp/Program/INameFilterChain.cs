namespace Program
{
    public interface INameFilterChain
    {
        void SetnextChain(INameFilterChain i_NextChain);

        float CalculateNameLength(NameCalculator i_NameCalculator);
    }
}
