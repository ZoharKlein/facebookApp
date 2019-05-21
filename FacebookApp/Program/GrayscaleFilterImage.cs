using System.Drawing;

namespace Program
{
    internal class GrayscaleFilterImage : FilterImage
    {
        internal GrayscaleFilterImage() : base(FilterFactory.eFilterKind.Grayscale)
        {
        }

        public override Bitmap ChangeFilterOfPicture(Image i_OrignalImage)
        {
            float rgb = 0;

            r_HandleImageInitAndClear.InitializeImage(i_OrignalImage);
            for (int k = 0; k < r_HandleImageInitAndClear.ByteBuffer.Length; k += 4)
            {
                rgb = r_HandleImageInitAndClear.ByteBuffer[k] * 0.11f;
                rgb += r_HandleImageInitAndClear.ByteBuffer[k + 1] * 0.59f;
                rgb += r_HandleImageInitAndClear.ByteBuffer[k + 2] * 0.3f;
                r_HandleImageInitAndClear.ByteBuffer[k] = (byte)rgb;
                r_HandleImageInitAndClear.ByteBuffer[k + 1] = r_HandleImageInitAndClear.ByteBuffer[k];
                r_HandleImageInitAndClear.ByteBuffer[k + 2] = r_HandleImageInitAndClear.ByteBuffer[k];
                r_HandleImageInitAndClear.ByteBuffer[k + 3] = 255;
            }

            r_HandleImageInitAndClear.ClearAndReplaceImageData();

            return r_HandleImageInitAndClear.NewBitmapImage;
        }
    }
}
