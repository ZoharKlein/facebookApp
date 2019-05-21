namespace Program
{
    internal class FilterFactory
    {
        public enum eFilterKind
        {
            Original,
            Grayscale,
            Negative,
            Vintage,
            Transparency
        }

        public static FilterImage CreateFilters(object i_FilterKind)
        {
            FilterImage filterToCreate;

            switch (i_FilterKind)
            {
                case eFilterKind.Original:
                    filterToCreate = new OriginalFilterImage();
                    break;
                case eFilterKind.Grayscale:
                    filterToCreate = new GrayscaleFilterImage();
                    break;
                case eFilterKind.Negative:
                    filterToCreate = new NegativeFilterImage();
                    break;
                case eFilterKind.Vintage:
                    filterToCreate = new VintageFilterImage();
                    break;
                case eFilterKind.Transparency:
                    filterToCreate = new TransparencyFilterImage();
                    break;
                default:
                    filterToCreate = null;
                    break;
            }

            return filterToCreate;
        }
    }
}
