using System.Drawing;

namespace Program
{
    internal class TransparencyFilterImage : FilterImage
    {
        internal TransparencyFilterImage() : base(FilterFactory.eFilterKind.Transparency)
        {
        }

        public override Bitmap ChangeFilterOfPicture(Image i_OrignalImage)
        {
            byte alphaComponent = 100;

            r_HandleImageInitAndClear.InitializeImage(i_OrignalImage);
            for (int k = 3; k < r_HandleImageInitAndClear.ByteBuffer.Length; k += 4)
            {
                r_HandleImageInitAndClear.ByteBuffer[k] = alphaComponent;
            }

            r_HandleImageInitAndClear.ClearAndReplaceImageData();

            return r_HandleImageInitAndClear.NewBitmapImage;
        }
    }
}
