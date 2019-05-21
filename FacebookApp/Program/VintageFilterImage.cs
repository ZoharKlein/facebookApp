using System.Drawing;

namespace Program
{
    internal class VintageFilterImage : FilterImage
    {
        internal VintageFilterImage() : base(FilterFactory.eFilterKind.Vintage)
        {
        }

        public override Bitmap ChangeFilterOfPicture(Image i_OrignalImage)
        {
            byte maxValue = 255;
            float r = 0;
            float g = 0;
            float b = 0;

            r_HandleImageInitAndClear.InitializeImage(i_OrignalImage);
            for (int k = 0; k < r_HandleImageInitAndClear.ByteBuffer.Length; k += 4)
            {
                r = (r_HandleImageInitAndClear.ByteBuffer[k] * 0.189f) + (r_HandleImageInitAndClear.ByteBuffer[k + 1] * 0.769f) + (r_HandleImageInitAndClear.ByteBuffer[k + 2] * 0.393f);
                g = (r_HandleImageInitAndClear.ByteBuffer[k] * 0.168f) + (r_HandleImageInitAndClear.ByteBuffer[k + 1] * 0.686f) + (r_HandleImageInitAndClear.ByteBuffer[k + 2] * 0.349f);
                b = (r_HandleImageInitAndClear.ByteBuffer[k] * 0.131f) + (r_HandleImageInitAndClear.ByteBuffer[k + 1] * 0.534f) + (r_HandleImageInitAndClear.ByteBuffer[k + 2] * 0.272f);
                r_HandleImageInitAndClear.ByteBuffer[k + 2] = r > maxValue ? maxValue : (byte)r;
                r_HandleImageInitAndClear.ByteBuffer[k + 1] = g > maxValue ? maxValue : (byte)g;
                r_HandleImageInitAndClear.ByteBuffer[k] = b > maxValue ? maxValue : (byte)b;
            }

            r_HandleImageInitAndClear.ClearAndReplaceImageData();

            return r_HandleImageInitAndClear.NewBitmapImage;
        }
    }
}
