namespace Program
{
    internal partial class FormDiscoverMeManageLikedPages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label label_Category;
            System.Windows.Forms.Label label_URL;
            System.Windows.Forms.Label label_Description;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscoverMeManageLikedPages));
            this.listBox_Liked_Pages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox_Liked_Pages = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Create_Category = new System.Windows.Forms.Button();
            this.button_Add_Page_To_Selected_Category = new System.Windows.Forms.Button();
            this.button_Remove_Selected_Item = new System.Windows.Forms.Button();
            this.textBox_Create_Category = new System.Windows.Forms.TextBox();
            this.treeView_Liked_Pages_Category = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox_Description = new System.Windows.Forms.TextBox();
            this.categoryLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.uRLLinkLabel = new System.Windows.Forms.LinkLabel();
            label_Category = new System.Windows.Forms.Label();
            label_URL = new System.Windows.Forms.Label();
            label_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Liked_Pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Location = new System.Drawing.Point(12, 54);
            label_Category.Name = "label_Category";
            label_Category.Size = new System.Drawing.Size(52, 13);
            label_Category.TabIndex = 0;
            label_Category.Text = "Category:";
            // 
            // label_URL
            // 
            label_URL.AutoSize = true;
            label_URL.Location = new System.Drawing.Point(12, 101);
            label_URL.Name = "label_URL";
            label_URL.Size = new System.Drawing.Size(32, 13);
            label_URL.TabIndex = 6;
            label_URL.Text = "URL:";
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new System.Drawing.Point(12, 77);
            label_Description.Name = "label_Description";
            label_Description.Size = new System.Drawing.Size(63, 13);
            label_Description.TabIndex = 7;
            label_Description.Text = "Description:";
            // 
            // listBox_Liked_Pages
            // 
            this.listBox_Liked_Pages.DataSource = this.pageBindingSource;
            this.listBox_Liked_Pages.DisplayMember = "Name";
            this.listBox_Liked_Pages.FormattingEnabled = true;
            this.listBox_Liked_Pages.Location = new System.Drawing.Point(12, 51);
            this.listBox_Liked_Pages.Name = "listBox_Liked_Pages";
            this.listBox_Liked_Pages.Size = new System.Drawing.Size(252, 134);
            this.listBox_Liked_Pages.TabIndex = 16;
            this.listBox_Liked_Pages.SelectedIndexChanged += new System.EventHandler(this.listBox_Liked_Pages_SelectedIndexChanged);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBox_Liked_Pages
            // 
            this.pictureBox_Liked_Pages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Liked_Pages.BackgroundImage")));
            this.pictureBox_Liked_Pages.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Liked_Pages.Name = "pictureBox_Liked_Pages";
            this.pictureBox_Liked_Pages.Size = new System.Drawing.Size(250, 40);
            this.pictureBox_Liked_Pages.TabIndex = 15;
            this.pictureBox_Liked_Pages.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 40);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button_Create_Category
            // 
            this.button_Create_Category.Enabled = false;
            this.button_Create_Category.Location = new System.Drawing.Point(287, 99);
            this.button_Create_Category.Name = "button_Create_Category";
            this.button_Create_Category.Size = new System.Drawing.Size(164, 23);
            this.button_Create_Category.TabIndex = 19;
            this.button_Create_Category.Text = "Create Category";
            this.button_Create_Category.UseVisualStyleBackColor = true;
            this.button_Create_Category.Click += new System.EventHandler(this.button_Create_Category_Click);
            // 
            // button_Add_Page_To_Selected_Category
            // 
            this.button_Add_Page_To_Selected_Category.Enabled = false;
            this.button_Add_Page_To_Selected_Category.Location = new System.Drawing.Point(287, 70);
            this.button_Add_Page_To_Selected_Category.Name = "button_Add_Page_To_Selected_Category";
            this.button_Add_Page_To_Selected_Category.Size = new System.Drawing.Size(164, 23);
            this.button_Add_Page_To_Selected_Category.TabIndex = 20;
            this.button_Add_Page_To_Selected_Category.Text = "Add page to selected Category";
            this.button_Add_Page_To_Selected_Category.UseVisualStyleBackColor = true;
            this.button_Add_Page_To_Selected_Category.Click += new System.EventHandler(this.button_Add_Page_To_Selected_Category_Click);
            // 
            // button_Remove_Selected_Item
            // 
            this.button_Remove_Selected_Item.Enabled = false;
            this.button_Remove_Selected_Item.Location = new System.Drawing.Point(287, 154);
            this.button_Remove_Selected_Item.Name = "button_Remove_Selected_Item";
            this.button_Remove_Selected_Item.Size = new System.Drawing.Size(164, 23);
            this.button_Remove_Selected_Item.TabIndex = 21;
            this.button_Remove_Selected_Item.Text = "Remove selected item";
            this.button_Remove_Selected_Item.UseVisualStyleBackColor = true;
            this.button_Remove_Selected_Item.Click += new System.EventHandler(this.button_Remove_Selected_Item_Click);
            // 
            // textBox_Create_Category
            // 
            this.textBox_Create_Category.Location = new System.Drawing.Point(287, 128);
            this.textBox_Create_Category.Name = "textBox_Create_Category";
            this.textBox_Create_Category.Size = new System.Drawing.Size(164, 20);
            this.textBox_Create_Category.TabIndex = 22;
            this.textBox_Create_Category.TextChanged += new System.EventHandler(this.textBox_Create_Category_TextChanged);
            // 
            // treeView_Liked_Pages_Category
            // 
            this.treeView_Liked_Pages_Category.Location = new System.Drawing.Point(474, 50);
            this.treeView_Liked_Pages_Category.Name = "treeView_Liked_Pages_Category";
            this.treeView_Liked_Pages_Category.Size = new System.Drawing.Size(250, 135);
            this.treeView_Liked_Pages_Category.TabIndex = 23;
            this.treeView_Liked_Pages_Category.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Liked_Pages_Category_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label_Description);
            this.panel1.Controls.Add(this.textbox_Description);
            this.panel1.Controls.Add(label_Category);
            this.panel1.Controls.Add(this.categoryLabel1);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(label_URL);
            this.panel1.Controls.Add(this.uRLLinkLabel);
            this.panel1.Location = new System.Drawing.Point(13, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 144);
            this.panel1.TabIndex = 24;
            // 
            // textbox_Description
            // 
            this.textbox_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.textbox_Description.Location = new System.Drawing.Point(81, 74);
            this.textbox_Description.Name = "textbox_Description";
            this.textbox_Description.Size = new System.Drawing.Size(152, 20);
            this.textbox_Description.TabIndex = 8;
            // 
            // categoryLabel1
            // 
            this.categoryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryLabel1.Location = new System.Drawing.Point(93, 54);
            this.categoryLabel1.Name = "categoryLabel1";
            this.categoryLabel1.Size = new System.Drawing.Size(100, 23);
            this.categoryLabel1.TabIndex = 1;
            this.categoryLabel1.Text = "Category name";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(15, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(49, 48);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // uRLLinkLabel
            // 
            this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
            this.uRLLinkLabel.Location = new System.Drawing.Point(93, 101);
            this.uRLLinkLabel.Name = "uRLLinkLabel";
            this.uRLLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.uRLLinkLabel.TabIndex = 7;
            this.uRLLinkLabel.TabStop = true;
            this.uRLLinkLabel.Text = "Link to visit";
            // 
            // FormDiscoverMeManageLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView_Liked_Pages_Category);
            this.Controls.Add(this.textBox_Create_Category);
            this.Controls.Add(this.button_Remove_Selected_Item);
            this.Controls.Add(this.button_Add_Page_To_Selected_Category);
            this.Controls.Add(this.button_Create_Category);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_Liked_Pages);
            this.Controls.Add(this.pictureBox_Liked_Pages);
            this.Name = "FormDiscoverMeManageLikedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.FormDiscoverMeManageLikedPages_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Liked_Pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Liked_Pages;
        private System.Windows.Forms.PictureBox pictureBox_Liked_Pages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Create_Category;
        private System.Windows.Forms.Button button_Add_Page_To_Selected_Category;
        private System.Windows.Forms.Button button_Remove_Selected_Item;
        private System.Windows.Forms.TextBox textBox_Create_Category;
        private System.Windows.Forms.TreeView treeView_Liked_Pages_Category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categoryLabel1;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel uRLLinkLabel;
        private System.Windows.Forms.TextBox textbox_Description;
    }
}