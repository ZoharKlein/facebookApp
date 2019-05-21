using System.Drawing;

namespace Program
{
    internal abstract class FilterImage
    {
        private readonly FilterFactory.eFilterKind r_FilterKind;
        protected readonly HandlingTheInitAndDeletionOfImages r_HandleImageInitAndClear;

        public FilterFactory.eFilterKind FilterName
        {
            get { return r_FilterKind; }
        }

        public FilterImage(FilterFactory.eFilterKind i_FilterName)
        {
            r_FilterKind = i_FilterName;
            r_HandleImageInitAndClear = new HandlingTheInitAndDeletionOfImages();
        }

        public abstract Bitmap ChangeFilterOfPicture(Image i_OrignalImage);
    }
}