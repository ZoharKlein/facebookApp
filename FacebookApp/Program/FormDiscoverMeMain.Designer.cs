namespace Program
{
    public partial class FormDiscoverMeMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string m_RichTextBoxPost = string.Empty;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_Description;
            System.Windows.Forms.Label label_End_Time;
            System.Windows.Forms.Label label_Start_Time;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscoverMeMain));
            this.pictureBox_UserProfileImage = new System.Windows.Forms.PictureBox();
            this.label_Profile_Email = new System.Windows.Forms.Label();
            this.label_Profile_Name = new System.Windows.Forms.Label();
            this.pictureBox_Male_Friends = new System.Windows.Forms.PictureBox();
            this.pictureBox_Female_Friends = new System.Windows.Forms.PictureBox();
            this.pictureBox_Birthdays = new System.Windows.Forms.PictureBox();
            this.listBox_Birthday = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox_Logout_Btn = new System.Windows.Forms.PictureBox();
            this.label_Friends_Menu_Bar = new System.Windows.Forms.Label();
            this.label_Sum_Of_All_Friends = new System.Windows.Forms.Label();
            this.label_Married_Menu_Bar = new System.Windows.Forms.Label();
            this.label_Sum_Of_All_Single = new System.Windows.Forms.Label();
            this.label_Single_Menu_Bar = new System.Windows.Forms.Label();
            this.label_Sum_Of_All_Married = new System.Windows.Forms.Label();
            this.richTextBox_Post = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Post = new System.Windows.Forms.PictureBox();
            this.comboBox_Filter_Profile_Image = new System.Windows.Forms.ComboBox();
            this.label_ChangeFilterImage = new System.Windows.Forms.Label();
            this.panel_Male_Friends = new System.Windows.Forms.Panel();
            this.button_Manage_Your_Liked_Pages = new System.Windows.Forms.Button();
            this.panel_Female_Friends = new System.Windows.Forms.Panel();
            this.panel_Events = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox_UserNameLength = new System.Windows.Forms.ComboBox();
            this.label_UserNameLength = new System.Windows.Forms.Label();
            this.textBox_UserNameLength = new System.Windows.Forms.TextBox();
            this.label_SortFriendsBy = new System.Windows.Forms.Label();
            this.comboBox_SortFriendsImageBy = new System.Windows.Forms.ComboBox();
            this.listBox_FriendMaleName = new System.Windows.Forms.ListBox();
            this.listBox_FriendFemaleName = new System.Windows.Forms.ListBox();
            label_Description = new System.Windows.Forms.Label();
            label_End_Time = new System.Windows.Forms.Label();
            label_Start_Time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Male_Friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Female_Friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Birthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Post)).BeginInit();
            this.panel_Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new System.Drawing.Point(9, 44);
            label_Description.Name = "label_Description";
            label_Description.Size = new System.Drawing.Size(63, 13);
            label_Description.TabIndex = 0;
            label_Description.Text = "Description:";
            // 
            // label_End_Time
            // 
            label_End_Time.AutoSize = true;
            label_End_Time.Location = new System.Drawing.Point(9, 98);
            label_End_Time.Name = "label_End_Time";
            label_End_Time.Size = new System.Drawing.Size(55, 13);
            label_End_Time.TabIndex = 2;
            label_End_Time.Text = "End Time:";
            // 
            // label_Start_Time
            // 
            label_Start_Time.AutoSize = true;
            label_Start_Time.Location = new System.Drawing.Point(9, 71);
            label_Start_Time.Name = "label_Start_Time";
            label_Start_Time.Size = new System.Drawing.Size(58, 13);
            label_Start_Time.TabIndex = 6;
            label_Start_Time.Text = "Start Time:";
            // 
            // pictureBox_UserProfileImage
            // 
            this.pictureBox_UserProfileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_UserProfileImage.Location = new System.Drawing.Point(127, 74);
            this.pictureBox_UserProfileImage.Name = "pictureBox_UserProfileImage";
            this.pictureBox_UserProfileImage.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_UserProfileImage.TabIndex = 4;
            this.pictureBox_UserProfileImage.TabStop = false;
            // 
            // label_Profile_Email
            // 
            this.label_Profile_Email.AutoSize = true;
            this.label_Profile_Email.BackColor = System.Drawing.Color.White;
            this.label_Profile_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Profile_Email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Profile_Email.Location = new System.Drawing.Point(215, 115);
            this.label_Profile_Email.Name = "label_Profile_Email";
            this.label_Profile_Email.Size = new System.Drawing.Size(0, 16);
            this.label_Profile_Email.TabIndex = 7;
            // 
            // label_Profile_Name
            // 
            this.label_Profile_Name.AutoSize = true;
            this.label_Profile_Name.BackColor = System.Drawing.Color.White;
            this.label_Profile_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Profile_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Profile_Name.Location = new System.Drawing.Point(215, 85);
            this.label_Profile_Name.Name = "label_Profile_Name";
            this.label_Profile_Name.Size = new System.Drawing.Size(0, 16);
            this.label_Profile_Name.TabIndex = 6;
            // 
            // pictureBox_Male_Friends
            // 
            this.pictureBox_Male_Friends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Male_Friends.BackgroundImage")));
            this.pictureBox_Male_Friends.Location = new System.Drawing.Point(22, 190);
            this.pictureBox_Male_Friends.Name = "pictureBox_Male_Friends";
            this.pictureBox_Male_Friends.Size = new System.Drawing.Size(170, 40);
            this.pictureBox_Male_Friends.TabIndex = 8;
            this.pictureBox_Male_Friends.TabStop = false;
            // 
            // pictureBox_Female_Friends
            // 
            this.pictureBox_Female_Friends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Female_Friends.BackgroundImage")));
            this.pictureBox_Female_Friends.Location = new System.Drawing.Point(212, 190);
            this.pictureBox_Female_Friends.Name = "pictureBox_Female_Friends";
            this.pictureBox_Female_Friends.Size = new System.Drawing.Size(170, 40);
            this.pictureBox_Female_Friends.TabIndex = 9;
            this.pictureBox_Female_Friends.TabStop = false;
            // 
            // pictureBox_Birthdays
            // 
            this.pictureBox_Birthdays.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Birthdays.BackgroundImage")));
            this.pictureBox_Birthdays.Location = new System.Drawing.Point(402, 190);
            this.pictureBox_Birthdays.Name = "pictureBox_Birthdays";
            this.pictureBox_Birthdays.Size = new System.Drawing.Size(250, 40);
            this.pictureBox_Birthdays.TabIndex = 11;
            this.pictureBox_Birthdays.TabStop = false;
            // 
            // listBox_Birthday
            // 
            this.listBox_Birthday.FormattingEnabled = true;
            this.listBox_Birthday.Location = new System.Drawing.Point(401, 228);
            this.listBox_Birthday.Name = "listBox_Birthday";
            this.listBox_Birthday.Size = new System.Drawing.Size(252, 238);
            this.listBox_Birthday.TabIndex = 15;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // pictureBox_Logout_Btn
            // 
            this.pictureBox_Logout_Btn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logout_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logout_Btn.BackgroundImage")));
            this.pictureBox_Logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Logout_Btn.Location = new System.Drawing.Point(902, 15);
            this.pictureBox_Logout_Btn.Name = "pictureBox_Logout_Btn";
            this.pictureBox_Logout_Btn.Size = new System.Drawing.Size(23, 30);
            this.pictureBox_Logout_Btn.TabIndex = 19;
            this.pictureBox_Logout_Btn.TabStop = false;
            this.pictureBox_Logout_Btn.Click += new System.EventHandler(this.pictureBox_Logout_Btn_Click);
            // 
            // label_Friends_Menu_Bar
            // 
            this.label_Friends_Menu_Bar.AutoSize = true;
            this.label_Friends_Menu_Bar.BackColor = System.Drawing.Color.White;
            this.label_Friends_Menu_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Friends_Menu_Bar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Friends_Menu_Bar.Location = new System.Drawing.Point(412, 115);
            this.label_Friends_Menu_Bar.Name = "label_Friends_Menu_Bar";
            this.label_Friends_Menu_Bar.Size = new System.Drawing.Size(53, 16);
            this.label_Friends_Menu_Bar.TabIndex = 24;
            this.label_Friends_Menu_Bar.Text = "Friends";
            // 
            // label_Sum_Of_All_Friends
            // 
            this.label_Sum_Of_All_Friends.AutoSize = true;
            this.label_Sum_Of_All_Friends.BackColor = System.Drawing.Color.White;
            this.label_Sum_Of_All_Friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Sum_Of_All_Friends.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Sum_Of_All_Friends.Location = new System.Drawing.Point(420, 85);
            this.label_Sum_Of_All_Friends.Name = "label_Sum_Of_All_Friends";
            this.label_Sum_Of_All_Friends.Size = new System.Drawing.Size(24, 26);
            this.label_Sum_Of_All_Friends.TabIndex = 25;
            this.label_Sum_Of_All_Friends.Text = "0";
            this.label_Sum_Of_All_Friends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Married_Menu_Bar
            // 
            this.label_Married_Menu_Bar.AutoSize = true;
            this.label_Married_Menu_Bar.BackColor = System.Drawing.Color.White;
            this.label_Married_Menu_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Married_Menu_Bar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Married_Menu_Bar.Location = new System.Drawing.Point(506, 115);
            this.label_Married_Menu_Bar.Name = "label_Married_Menu_Bar";
            this.label_Married_Menu_Bar.Size = new System.Drawing.Size(54, 16);
            this.label_Married_Menu_Bar.TabIndex = 26;
            this.label_Married_Menu_Bar.Text = "Married";
            // 
            // label_Sum_Of_All_Single
            // 
            this.label_Sum_Of_All_Single.AutoSize = true;
            this.label_Sum_Of_All_Single.BackColor = System.Drawing.Color.White;
            this.label_Sum_Of_All_Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Sum_Of_All_Single.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Sum_Of_All_Single.Location = new System.Drawing.Point(603, 85);
            this.label_Sum_Of_All_Single.Name = "label_Sum_Of_All_Single";
            this.label_Sum_Of_All_Single.Size = new System.Drawing.Size(24, 26);
            this.label_Sum_Of_All_Single.TabIndex = 29;
            this.label_Sum_Of_All_Single.Text = "0";
            this.label_Sum_Of_All_Single.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Single_Menu_Bar
            // 
            this.label_Single_Menu_Bar.AutoSize = true;
            this.label_Single_Menu_Bar.BackColor = System.Drawing.Color.White;
            this.label_Single_Menu_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Single_Menu_Bar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Single_Menu_Bar.Location = new System.Drawing.Point(595, 115);
            this.label_Single_Menu_Bar.Name = "label_Single_Menu_Bar";
            this.label_Single_Menu_Bar.Size = new System.Drawing.Size(46, 16);
            this.label_Single_Menu_Bar.TabIndex = 28;
            this.label_Single_Menu_Bar.Text = "Single";
            // 
            // label_Sum_Of_All_Married
            // 
            this.label_Sum_Of_All_Married.AutoSize = true;
            this.label_Sum_Of_All_Married.BackColor = System.Drawing.Color.White;
            this.label_Sum_Of_All_Married.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Sum_Of_All_Married.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Sum_Of_All_Married.Location = new System.Drawing.Point(514, 85);
            this.label_Sum_Of_All_Married.Name = "label_Sum_Of_All_Married";
            this.label_Sum_Of_All_Married.Size = new System.Drawing.Size(24, 26);
            this.label_Sum_Of_All_Married.TabIndex = 30;
            this.label_Sum_Of_All_Married.Text = "0";
            this.label_Sum_Of_All_Married.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_Post
            // 
            this.richTextBox_Post.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_Post.Location = new System.Drawing.Point(672, 74);
            this.richTextBox_Post.Name = "richTextBox_Post";
            this.richTextBox_Post.Size = new System.Drawing.Size(260, 70);
            this.richTextBox_Post.TabIndex = 31;
            this.richTextBox_Post.Text = "Post something...";
            this.richTextBox_Post.Click += new System.EventHandler(this.richTextBox_Post_Click);
            // 
            // pictureBox_Post
            // 
            this.pictureBox_Post.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Post.BackgroundImage")));
            this.pictureBox_Post.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Post.Location = new System.Drawing.Point(855, 111);
            this.pictureBox_Post.Name = "pictureBox_Post";
            this.pictureBox_Post.Size = new System.Drawing.Size(70, 29);
            this.pictureBox_Post.TabIndex = 32;
            this.pictureBox_Post.TabStop = false;
            this.pictureBox_Post.Click += new System.EventHandler(this.pictureBox_Post_Click);
            // 
            // comboBox_Filter_Profile_Image
            // 
            this.comboBox_Filter_Profile_Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter_Profile_Image.FormattingEnabled = true;
            this.comboBox_Filter_Profile_Image.Items.AddRange(new object[] {
            "Original",
            "Grayscale",
            "Negative",
            "Vintage",
            "Transparency"});
            this.comboBox_Filter_Profile_Image.Location = new System.Drawing.Point(10, 101);
            this.comboBox_Filter_Profile_Image.Name = "comboBox_Filter_Profile_Image";
            this.comboBox_Filter_Profile_Image.Size = new System.Drawing.Size(111, 21);
            this.comboBox_Filter_Profile_Image.TabIndex = 33;
            this.comboBox_Filter_Profile_Image.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Profile_Image_SelectedIndexChanged);
            // 
            // label_ChangeFilterImage
            // 
            this.label_ChangeFilterImage.AutoSize = true;
            this.label_ChangeFilterImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ChangeFilterImage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_ChangeFilterImage.Location = new System.Drawing.Point(7, 75);
            this.label_ChangeFilterImage.Name = "label_ChangeFilterImage";
            this.label_ChangeFilterImage.Size = new System.Drawing.Size(114, 15);
            this.label_ChangeFilterImage.TabIndex = 34;
            this.label_ChangeFilterImage.Text = "Change filter image";
            // 
            // panel_Male_Friends
            // 
            this.panel_Male_Friends.AutoScroll = true;
            this.panel_Male_Friends.Location = new System.Drawing.Point(22, 228);
            this.panel_Male_Friends.Name = "panel_Male_Friends";
            this.panel_Male_Friends.Size = new System.Drawing.Size(170, 238);
            this.panel_Male_Friends.TabIndex = 35;
            // 
            // button_Manage_Your_Liked_Pages
            // 
            this.button_Manage_Your_Liked_Pages.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Manage_Your_Liked_Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Manage_Your_Liked_Pages.Location = new System.Drawing.Point(672, 266);
            this.button_Manage_Your_Liked_Pages.Name = "button_Manage_Your_Liked_Pages";
            this.button_Manage_Your_Liked_Pages.Size = new System.Drawing.Size(250, 23);
            this.button_Manage_Your_Liked_Pages.TabIndex = 36;
            this.button_Manage_Your_Liked_Pages.Text = "Show and Manage your Liked Pages";
            this.button_Manage_Your_Liked_Pages.UseVisualStyleBackColor = false;
            this.button_Manage_Your_Liked_Pages.Click += new System.EventHandler(this.button_Manage_Your_Liked_Pages_Click);
            // 
            // panel_Female_Friends
            // 
            this.panel_Female_Friends.AutoScroll = true;
            this.panel_Female_Friends.Location = new System.Drawing.Point(212, 228);
            this.panel_Female_Friends.Name = "panel_Female_Friends";
            this.panel_Female_Friends.Size = new System.Drawing.Size(170, 238);
            this.panel_Female_Friends.TabIndex = 36;
            // 
            // panel_Events
            // 
            this.panel_Events.Controls.Add(label_Description);
            this.panel_Events.Controls.Add(this.descriptionTextBox);
            this.panel_Events.Controls.Add(label_End_Time);
            this.panel_Events.Controls.Add(this.endTimeDateTimePicker);
            this.panel_Events.Controls.Add(this.imageNormalPictureBox);
            this.panel_Events.Controls.Add(label_Start_Time);
            this.panel_Events.Controls.Add(this.startTimeDateTimePicker);
            this.panel_Events.Location = new System.Drawing.Point(674, 343);
            this.panel_Events.Name = "panel_Events";
            this.panel_Events.Size = new System.Drawing.Size(251, 123);
            this.panel_Events.TabIndex = 38;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(90, 41);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(149, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(90, 94);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(12, 6);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(30, 30);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(90, 67);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.startTimeDateTimePicker.TabIndex = 7;
            // 
            // comboBox_UserNameLength
            // 
            this.comboBox_UserNameLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UserNameLength.FormattingEnabled = true;
            this.comboBox_UserNameLength.Items.AddRange(new object[] {
            "Average",
            "Min",
            "Max"});
            this.comboBox_UserNameLength.Location = new System.Drawing.Point(685, 226);
            this.comboBox_UserNameLength.Name = "comboBox_UserNameLength";
            this.comboBox_UserNameLength.Size = new System.Drawing.Size(120, 21);
            this.comboBox_UserNameLength.TabIndex = 39;
            this.comboBox_UserNameLength.SelectedIndexChanged += new System.EventHandler(this.comboBox_UserNameLength_SelectedIndexChanged);
            // 
            // label_UserNameLength
            // 
            this.label_UserNameLength.AutoSize = true;
            this.label_UserNameLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_UserNameLength.Location = new System.Drawing.Point(682, 190);
            this.label_UserNameLength.Name = "label_UserNameLength";
            this.label_UserNameLength.Size = new System.Drawing.Size(209, 17);
            this.label_UserNameLength.TabIndex = 40;
            this.label_UserNameLength.Text = "Show User Name Length By";
            // 
            // textBox_UserNameLength
            // 
            this.textBox_UserNameLength.Enabled = false;
            this.textBox_UserNameLength.Location = new System.Drawing.Point(820, 227);
            this.textBox_UserNameLength.MaxLength = 20;
            this.textBox_UserNameLength.Name = "textBox_UserNameLength";
            this.textBox_UserNameLength.Size = new System.Drawing.Size(42, 20);
            this.textBox_UserNameLength.TabIndex = 41;
            // 
            // label_SortFriendsBy
            // 
            this.label_SortFriendsBy.AutoSize = true;
            this.label_SortFriendsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_SortFriendsBy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_SortFriendsBy.Location = new System.Drawing.Point(22, 168);
            this.label_SortFriendsBy.Name = "label_SortFriendsBy";
            this.label_SortFriendsBy.Size = new System.Drawing.Size(130, 15);
            this.label_SortFriendsBy.TabIndex = 42;
            this.label_SortFriendsBy.Text = "Sort Friends Image By:";
            // 
            // comboBox_SortFriendsImageBy
            // 
            this.comboBox_SortFriendsImageBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SortFriendsImageBy.FormattingEnabled = true;
            this.comboBox_SortFriendsImageBy.Items.AddRange(new object[] {
            "Min Length Name",
            "Max Length Name",
            "Alphabet"});
            this.comboBox_SortFriendsImageBy.Location = new System.Drawing.Point(159, 165);
            this.comboBox_SortFriendsImageBy.Name = "comboBox_SortFriendsImageBy";
            this.comboBox_SortFriendsImageBy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SortFriendsImageBy.TabIndex = 43;
            this.comboBox_SortFriendsImageBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SortFriendsImageBy_SelectedIndexChanged);
            // 
            // listBox_FriendMaleName
            // 
            this.listBox_FriendMaleName.FormattingEnabled = true;
            this.listBox_FriendMaleName.Location = new System.Drawing.Point(22, 476);
            this.listBox_FriendMaleName.Name = "listBox_FriendMaleName";
            this.listBox_FriendMaleName.Size = new System.Drawing.Size(170, 56);
            this.listBox_FriendMaleName.TabIndex = 46;
            // 
            // listBox_FriendFemaleName
            // 
            this.listBox_FriendFemaleName.FormattingEnabled = true;
            this.listBox_FriendFemaleName.Location = new System.Drawing.Point(212, 476);
            this.listBox_FriendFemaleName.Name = "listBox_FriendFemaleName";
            this.listBox_FriendFemaleName.Size = new System.Drawing.Size(170, 56);
            this.listBox_FriendFemaleName.TabIndex = 47;
            // 
            // FormDiscoverMeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 555);
            this.Controls.Add(this.listBox_FriendFemaleName);
            this.Controls.Add(this.listBox_FriendMaleName);
            this.Controls.Add(this.comboBox_SortFriendsImageBy);
            this.Controls.Add(this.label_SortFriendsBy);
            this.Controls.Add(this.textBox_UserNameLength);
            this.Controls.Add(this.label_UserNameLength);
            this.Controls.Add(this.comboBox_UserNameLength);
            this.Controls.Add(this.panel_Events);
            this.Controls.Add(this.panel_Female_Friends);
            this.Controls.Add(this.button_Manage_Your_Liked_Pages);
            this.Controls.Add(this.panel_Male_Friends);
            this.Controls.Add(this.label_ChangeFilterImage);
            this.Controls.Add(this.comboBox_Filter_Profile_Image);
            this.Controls.Add(this.pictureBox_Post);
            this.Controls.Add(this.richTextBox_Post);
            this.Controls.Add(this.label_Sum_Of_All_Married);
            this.Controls.Add(this.label_Sum_Of_All_Single);
            this.Controls.Add(this.label_Single_Menu_Bar);
            this.Controls.Add(this.label_Married_Menu_Bar);
            this.Controls.Add(this.label_Sum_Of_All_Friends);
            this.Controls.Add(this.label_Friends_Menu_Bar);
            this.Controls.Add(this.pictureBox_Logout_Btn);
            this.Controls.Add(this.listBox_Birthday);
            this.Controls.Add(this.pictureBox_Birthdays);
            this.Controls.Add(this.pictureBox_Female_Friends);
            this.Controls.Add(this.pictureBox_Male_Friends);
            this.Controls.Add(this.label_Profile_Email);
            this.Controls.Add(this.label_Profile_Name);
            this.Controls.Add(this.pictureBox_UserProfileImage);
            this.MaximizeBox = false;
            this.Name = "FormDiscoverMeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.DiscoverMeMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Male_Friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Female_Friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Birthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Post)).EndInit();
            this.panel_Events.ResumeLayout(false);
            this.panel_Events.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_UserProfileImage;
        private System.Windows.Forms.Label label_Profile_Email;
        private System.Windows.Forms.Label label_Profile_Name;
        private System.Windows.Forms.PictureBox pictureBox_Male_Friends;
        private System.Windows.Forms.PictureBox pictureBox_Female_Friends;
        private System.Windows.Forms.PictureBox pictureBox_Birthdays;
        private System.Windows.Forms.ListBox listBox_Birthday;
        private System.Windows.Forms.PictureBox pictureBox_Logout_Btn;
        private System.Windows.Forms.Label label_Friends_Menu_Bar;
        private System.Windows.Forms.Label label_Sum_Of_All_Friends;
        private System.Windows.Forms.Label label_Married_Menu_Bar;
        private System.Windows.Forms.Label label_Sum_Of_All_Single;
        private System.Windows.Forms.Label label_Single_Menu_Bar;
        private System.Windows.Forms.Label label_Sum_Of_All_Married;
        private System.Windows.Forms.RichTextBox richTextBox_Post;
        private System.Windows.Forms.PictureBox pictureBox_Post;
        private System.Windows.Forms.ComboBox comboBox_Filter_Profile_Image;
        private System.Windows.Forms.Label label_ChangeFilterImage;
        private System.Windows.Forms.Panel panel_Male_Friends;
        private System.Windows.Forms.Button button_Manage_Your_Liked_Pages;
        private System.Windows.Forms.Panel panel_Female_Friends;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panel_Events;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_UserNameLength;
        private System.Windows.Forms.Label label_UserNameLength;
        private System.Windows.Forms.TextBox textBox_UserNameLength;
        private System.Windows.Forms.Label label_SortFriendsBy;
        private System.Windows.Forms.ComboBox comboBox_SortFriendsImageBy;
        private System.Windows.Forms.ListBox listBox_FriendMaleName;
        private System.Windows.Forms.ListBox listBox_FriendFemaleName;
    }
}