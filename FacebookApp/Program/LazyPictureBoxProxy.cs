using System.Windows.Forms;

namespace Program
{
    public class LazyPictureBoxProxy : PictureBox
    {
        public string URL { get; set; }

        public void Load(string i_UrlToLoad)
        {
            URL = i_UrlToLoad;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (ImageLocation == null)
            {
                ImageLocation = this.URL;
            }

            base.OnPaint(pe);
        }
    }
}