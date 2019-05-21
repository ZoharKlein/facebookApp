using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Program
{
    public partial class FormDiscoverMeMain : Form
    {
        public FormDiscoverMeMain()
        {
            InitializeComponent();
            initializeFormData();
        }
        
        private readonly FormDiscoverMeManageLikedPages r_FormDiscoverMeManageLikedPages = new FormDiscoverMeManageLikedPages();
        private readonly FacadeFilterImage r_FacadeFilterImage = new FacadeFilterImage();
        private readonly FacadeFormDiscoverMeMain r_FacadeFormDiscoverMeMain = new FacadeFormDiscoverMeMain();

        public int PositionOfPictureInPanelFromLeft { get; set; }

        public int IndexLineCounter { get; set; }

        private void initializeFormData()
        {
            loginAndInit();
            FormDiscoverMeLogin.Instance.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void loginAndInit()
        {
            r_FacadeFormDiscoverMeMain.LoginAndInit();
            loadProfileImage();
            if (!this.IsHandleCreated)
            {
                IntPtr handle = this.Handle;
            }

            if (this.IsHandleCreated == true)
            {
                new Thread(loadBasicInfoOnMenuBar).Start();
                new Thread(showAllDataOnListBox).Start();
            }
        }

        private void loadProfileImage()
        {
            r_FacadeFormDiscoverMeMain.LoadProfileImage();
            pictureBox_UserProfileImage.Load(r_FacadeFormDiscoverMeMain.ProfilePictuerStr);
            r_FacadeFormDiscoverMeMain.m_OriginalProfilePictureImage = pictureBox_UserProfileImage.Image;
            this.pictureBox_UserProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadBasicInfoOnMenuBar()
        {
            r_FacadeFormDiscoverMeMain.LoadBasicInfoOnMenuBar();
            label_Profile_Name.Invoke(new Action(() => label_Profile_Name.Text = r_FacadeFormDiscoverMeMain.ProfileNameStr));
            label_Profile_Email.Invoke(new Action(() => label_Profile_Email.Text = r_FacadeFormDiscoverMeMain.ProfileEmailStr));
        }

        private void showAllDataOnListBox()
        {
            new Thread(fetchFriends).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchBirthdays).Start();
        }

        private void fetchFriends()
        {
            r_FacadeFormDiscoverMeMain.FetchFriends();
            initPositionOfPictures();
            fetchMaleFriends();
            initPositionOfPictures();
            fetchFemaleFriends();
            updateLabelsOnMenuBar();
            showDataOnListBoxOfFriendsName();
        }

        private void initPositionOfPictures()
        {
            PositionOfPictureInPanelFromLeft = 3;
            IndexLineCounter = 0;
        }

        private void fetchMaleFriends()
        {
            this.panel_Male_Friends.Controls.Clear();
            initPositionOfPictures();
            int pictureWidth = (panel_Male_Friends.Width / 2) - 10;
            int pictureHeight = pictureWidth;

            foreach (DiscoverMeUser friend in r_FacadeFormDiscoverMeMain.MaleFriends)
            {
                panel_Male_Friends.Invoke(new Action(() => panel_Male_Friends.Controls.Add(fetchPanelPicture(friend, pictureWidth, pictureHeight))));
            }
        }

        private void fetchFemaleFriends()
        {
            this.panel_Female_Friends.Controls.Clear();
            initPositionOfPictures();
            int pictureWidth = (panel_Female_Friends.Width / 2) - 10;
            int pictureHeight = pictureWidth;

            foreach (DiscoverMeUser friend in r_FacadeFormDiscoverMeMain.FemaleFriends)
            {
                panel_Female_Friends.Invoke(new Action(() => panel_Female_Friends.Controls.Add(fetchPanelPicture(friend, pictureWidth, pictureHeight))));
            }
        }

        private LazyPictureBoxProxy fetchPanelPicture(DiscoverMeUser i_Friend, int i_Width, int i_Height)
        {
            LazyPictureBoxProxy friendPhoto = new LazyPictureBoxProxy();
            friendPhoto.Size = new System.Drawing.Size(i_Width, i_Height);
            friendPhoto.Left = 3 + (((IndexLineCounter % 2) * friendPhoto.Right) + ((IndexLineCounter % 2) * 3));
            friendPhoto.Top = PositionOfPictureInPanelFromLeft;
            friendPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            friendPhoto.Load(i_Friend.PictureNormalURL);
            if (IndexLineCounter % 2 != 0)
            {
                PositionOfPictureInPanelFromLeft = friendPhoto.Bottom + 2;
            }

            IndexLineCounter++;

            return friendPhoto;
        }

        private void updateLabelsOnMenuBar()
        {
            this.label_Sum_Of_All_Friends.Invoke(new Action(() => this.label_Sum_Of_All_Friends.Text = r_FacadeFormDiscoverMeMain.SumOfAllFriends.ToString()));
            this.label_Sum_Of_All_Married.Invoke(new Action(() => this.label_Sum_Of_All_Married.Text = r_FacadeFormDiscoverMeMain.SumOfAllMarried.ToString()));
            this.label_Sum_Of_All_Single.Invoke(new Action(() => this.label_Sum_Of_All_Single.Text = r_FacadeFormDiscoverMeMain.SumOfAllSingle.ToString()));
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = this.r_FacadeFormDiscoverMeMain.LoggedInUser.Events;
        }

        private void fetchBirthdays()
        {
            int friendBirthdayMonth;
            int friendBirthdayDay;
            bool isValidMonth = false;
            bool isValidDay = false;
            List<DiscoverMeUser> listOfAllFriends = new List<DiscoverMeUser>();
            listOfAllFriends = r_FacadeFormDiscoverMeMain.getAllFriends();

            foreach (DiscoverMeUser friendDOB in listOfAllFriends)
            {
                try
                {
                    isValidMonth = int.TryParse(friendDOB.Birthday.Substring(0, 2), out friendBirthdayMonth);
                    isValidDay = int.TryParse(friendDOB.Birthday.Substring(3, 2), out friendBirthdayDay);

                    if (isValidMonth == true && isValidDay == true)
                    {
                        if (DateTime.Now.Month == friendBirthdayMonth && friendBirthdayDay >= DateTime.Now.Day)
                        {
                            listBox_Birthday.Invoke(new Action(() => listBox_Birthday.Items.Add(string.Format("{0} - {1}th", friendDOB.FirstName, friendBirthdayDay))));
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
        }

        private void richTextBox_Post_Click(object sender, EventArgs e)
        {
            this.richTextBox_Post.BackColor = Color.White;
            this.richTextBox_Post.Text = string.Empty;
        }

        private void DiscoverMeMain_Click(object sender, EventArgs e)
        {
            this.richTextBox_Post.BackColor = Control.DefaultBackColor;
            this.richTextBox_Post.Text = m_RichTextBoxPost;
        }

        private void pictureBox_Post_Click(object sender, EventArgs e)
        {
            postUserComment();
        }

        private void postUserComment()
        {
            try
            {
                Status status = r_FacadeFormDiscoverMeMain.PostStatus(richTextBox_Post.Text);
                status.Like();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void comboBox_Filter_Profile_Image_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeProfilePictureBySelectedItem();
        }

        private void changeProfilePictureBySelectedItem()
        {
            pictureBox_UserProfileImage.Image = r_FacadeFormDiscoverMeMain.ChangeProfilePictureBySelectedItem(comboBox_Filter_Profile_Image.SelectedItem.ToString());
        }

        private void pictureBox_Logout_Btn_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logout);
        }

        private void logout()
        {
            this.Hide();
            FormDiscoverMeLogin.Instance.FormClosed += (s, args) => this.Close();
            FormDiscoverMeLogin.Instance.Show();
            FormDiscoverMeLogin.Instance.Focus();
        }

        private void button_Manage_Your_Liked_Pages_Click(object sender, EventArgs e)
        {
            r_FormDiscoverMeManageLikedPages.ShowFormLikedPages(r_FacadeFormDiscoverMeMain.LoggedInUser);
        }

        private void comboBox_UserNameLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            showResultOfUserChoice();            
        }

        private void showResultOfUserChoice()
        {
            ConnectAllChain connectAllChain = new ConnectAllChain();

            eCalculateRequest selectedChoice = (eCalculateRequest)Enum.Parse(typeof(eCalculateRequest), comboBox_UserNameLength.SelectedIndex.ToString(), true);

            float result = connectAllChain.SetAndCalcByUserChoice(this.r_FacadeFormDiscoverMeMain.getAllFriendsNames(), selectedChoice);

            this.textBox_UserNameLength.Text = result.ToString();
        }

        private void comboBox_SortFriendsImageBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortFriendsImageByUserChoice();
        }

        private void sortFriendsImageByUserChoice()
        {
            this.r_FacadeFormDiscoverMeMain.sortFriendImagesByUserChoice(this.comboBox_SortFriendsImageBy.SelectedIndex);
            new Thread(fetchMaleFriends).Start();
            new Thread(fetchFemaleFriends).Start();
            showDataOnListBoxOfFriendsName();
        }

        private void showDataOnListBoxOfFriendsName()
        {
            this.listBox_FriendMaleName.Items.Clear();
            this.listBox_FriendFemaleName.Items.Clear();

            foreach (DiscoverMeUser friend in r_FacadeFormDiscoverMeMain.MaleFriends)
            {
                this.listBox_FriendMaleName.Invoke(new Action(() => this.listBox_FriendMaleName.Items.Add(friend.FirstName)));
            }

            foreach (DiscoverMeUser friend in r_FacadeFormDiscoverMeMain.FemaleFriends)
            {
                this.listBox_FriendFemaleName.Invoke(new Action(() => this.listBox_FriendFemaleName.Items.Add(friend.FirstName)));
            }
        }
    }
}