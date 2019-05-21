using System;
using System.Drawing;

namespace Program
{
    internal class NegativeFilterImage : FilterImage
    {
        internal NegativeFilterImage() : base(FilterFactory.eFilterKind.Negative)
        {
        }

        public override Bitmap ChangeFilterOfPicture(Image i_OrignalImage)
        {
            byte[] pixelBuffer = null;
            int pixel = 0;

            r_HandleImageInitAndClear.InitializeImage(i_OrignalImage);
            for (int k = 0; k < r_HandleImageInitAndClear.ByteBuffer.Length; k += 4)
            {
                pixel = ~BitConverter.ToInt32(r_HandleImageInitAndClear.ByteBuffer, k);
                pixelBuffer = BitConverter.GetBytes(pixel);
                r_HandleImageInitAndClear.ByteBuffer[k] = pixelBuffer[0];
                r_HandleImageInitAndClear.ByteBuffer[k + 1] = pixelBuffer[1];
                r_HandleImageInitAndClear.ByteBuffer[k + 2] = pixelBuffer[2];
            }

            r_HandleImageInitAndClear.ClearAndReplaceImageData();

            return r_HandleImageInitAndClear.NewBitmapImage;
        }
    }
}
