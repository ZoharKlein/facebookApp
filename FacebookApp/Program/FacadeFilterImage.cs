using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    internal class FacadeFilterImage
    {
        private readonly List<FilterImage> r_FilterImagesList = new List<FilterImage>();

        public Image OriginalProfilePicture { get; set; }

        public FacadeFilterImage()
        {
            if(r_FilterImagesList.Count == 0)
            {
                CreateInstanceOfFilterImage();
            }
        }

        public Image ChangeFilterImage(string i_SelectedChoiceOfFilterImage)
        {
            PictureBox profilePicture = new PictureBox();

            foreach (FilterImage filterImg in r_FilterImagesList)
            {
                if (i_SelectedChoiceOfFilterImage == filterImg.FilterName.ToString())
                {
                    profilePicture.Image = filterImg.ChangeFilterOfPicture(OriginalProfilePicture);
                    break;
                }
            }

            return profilePicture.Image;
        }

        private void CreateInstanceOfFilterImage()
        {
            foreach (FilterFactory.eFilterKind kind in (FilterFactory.eFilterKind[])Enum.GetValues(typeof(FilterFactory.eFilterKind)))
            {
                r_FilterImagesList.Add(FilterFactory.CreateFilters(kind));
            }
        }
    }
}
