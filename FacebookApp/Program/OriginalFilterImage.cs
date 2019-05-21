using System;
using System.Drawing;

namespace Program
{
    internal class OriginalFilterImage : FilterImage
    {
        internal OriginalFilterImage() : base(FilterFactory.eFilterKind.Original)
        {
        }

        public override Bitmap ChangeFilterOfPicture(Image i_OrignalImage)
        {
            return (Bitmap)i_OrignalImage;
        }
    }
}
