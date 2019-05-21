using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Program
{
    internal class HandlingTheInitAndDeletionOfImages
    {
        public Bitmap NewBitmapImage { get; set; }

        public BitmapData NewBitmapData { get; set; }

        public byte[] ByteBuffer { get; set; }

        public HandlingTheInitAndDeletionOfImages()
        {
        }

        internal void InitializeImage(Image i_OrignalImage)
        {
            NewBitmapImage = new Bitmap(i_OrignalImage);
            NewBitmapData = NewBitmapImage.LockBits(new Rectangle(0, 0, i_OrignalImage.Width, i_OrignalImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            ByteBuffer = new byte[NewBitmapData.Stride * NewBitmapImage.Height];
            Marshal.Copy(NewBitmapData.Scan0, ByteBuffer, 0, ByteBuffer.Length);
        }

        internal void ClearAndReplaceImageData()
        {
            Marshal.Copy(ByteBuffer, 0, NewBitmapData.Scan0, ByteBuffer.Length);
            NewBitmapImage.UnlockBits(NewBitmapData);
            NewBitmapData = null;
            ByteBuffer = null;
        }
    }
}