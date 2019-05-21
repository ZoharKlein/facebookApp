namespace Program
{
    public partial class FormDiscoverMeLogin
    {
        private System.ComponentModel.IContainer components = null;
        private string m_TextBoxCustomText = string.Empty;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscoverMeLogin));
            this.pictureBox_Login_bgnd = new System.Windows.Forms.PictureBox();
            this.pictureBox_login_btn = new System.Windows.Forms.PictureBox();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.textBox_Custom_App_ID = new System.Windows.Forms.TextBox();
            this.radioButton_Custom_App_ID = new System.Windows.Forms.RadioButton();
            this.radioButton_My_New_App_ID = new System.Windows.Forms.RadioButton();
            this.radioButton_Demo_App_ID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_bgnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_btn)).BeginInit();
            this.groupBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Login_bgnd
            // 
            this.pictureBox_Login_bgnd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login_bgnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Login_bgnd.BackgroundImage")));
            this.pictureBox_Login_bgnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_Login_bgnd.Location = new System.Drawing.Point(140, 135);
            this.pictureBox_Login_bgnd.Name = "pictureBox_Login_bgnd";
            this.pictureBox_Login_bgnd.Size = new System.Drawing.Size(660, 340);
            this.pictureBox_Login_bgnd.TabIndex = 1;
            this.pictureBox_Login_bgnd.TabStop = false;
            // 
            // pictureBox_login_btn
            // 
            this.pictureBox_login_btn.BackColor = System.Drawing.Color.White;
            this.pictureBox_login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_login_btn.BackgroundImage")));
            this.pictureBox_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_login_btn.Location = new System.Drawing.Point(175, 390);
            this.pictureBox_login_btn.Name = "pictureBox_login_btn";
            this.pictureBox_login_btn.Size = new System.Drawing.Size(224, 48);
            this.pictureBox_login_btn.TabIndex = 2;
            this.pictureBox_login_btn.TabStop = false;
            this.pictureBox_login_btn.Click += new System.EventHandler(this.pictureBox_login_btn_Click);
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.BackColor = System.Drawing.Color.White;
            this.groupBox_Settings.Controls.Add(this.textBox_Custom_App_ID);
            this.groupBox_Settings.Controls.Add(this.radioButton_Custom_App_ID);
            this.groupBox_Settings.Controls.Add(this.radioButton_My_New_App_ID);
            this.groupBox_Settings.Controls.Add(this.radioButton_Demo_App_ID);
            this.groupBox_Settings.Location = new System.Drawing.Point(443, 208);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(332, 191);
            this.groupBox_Settings.TabIndex = 3;
            this.groupBox_Settings.TabStop = false;
            // 
            // textBox_Custom_App_ID
            // 
            this.textBox_Custom_App_ID.Enabled = false;
            this.textBox_Custom_App_ID.Location = new System.Drawing.Point(107, 63);
            this.textBox_Custom_App_ID.Name = "textBox_Custom_App_ID";
            this.textBox_Custom_App_ID.Size = new System.Drawing.Size(124, 20);
            this.textBox_Custom_App_ID.TabIndex = 3;
            this.textBox_Custom_App_ID.Text = "Enter App ID";
            this.m_TextBoxCustomText = this.textBox_Custom_App_ID.Text;
            // 
            // radioButton_Custom_App_ID
            // 
            this.radioButton_Custom_App_ID.AutoSize = true;
            this.radioButton_Custom_App_ID.Location = new System.Drawing.Point(6, 66);
            this.radioButton_Custom_App_ID.Name = "radioButton_Custom_App_ID";
            this.radioButton_Custom_App_ID.Size = new System.Drawing.Size(99, 17);
            this.radioButton_Custom_App_ID.TabIndex = 2;
            this.radioButton_Custom_App_ID.TabStop = true;
            this.radioButton_Custom_App_ID.Text = "Custom App ID:";
            this.radioButton_Custom_App_ID.UseVisualStyleBackColor = true;
            this.radioButton_Custom_App_ID.CheckedChanged += new System.EventHandler(this.radioButton_Custom_App_ID_CheckedChanged);
            // 
            // radioButton_My_New_App_ID
            // 
            this.radioButton_My_New_App_ID.AutoSize = true;
            this.radioButton_My_New_App_ID.Location = new System.Drawing.Point(6, 43);
            this.radioButton_My_New_App_ID.Name = "radioButton_My_New_App_ID";
            this.radioButton_My_New_App_ID.Size = new System.Drawing.Size(203, 17);
            this.radioButton_My_New_App_ID.TabIndex = 1;
            this.radioButton_My_New_App_ID.TabStop = true;
            this.radioButton_My_New_App_ID.Text = "Demo App ID:     1450160541956417";
            this.radioButton_My_New_App_ID.UseVisualStyleBackColor = true;
            this.radioButton_My_New_App_ID.CheckedChanged += new System.EventHandler(this.radioButton_My_New_App_ID_CheckedChanged);
            // 
            // radioButton_Demo_App_ID
            // 
            this.radioButton_Demo_App_ID.AutoSize = true;
            this.radioButton_Demo_App_ID.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Demo_App_ID.Name = "radioButton_Demo_App_ID";
            this.radioButton_Demo_App_ID.Size = new System.Drawing.Size(197, 17);
            this.radioButton_Demo_App_ID.TabIndex = 0;
            this.radioButton_Demo_App_ID.TabStop = true;
            this.radioButton_Demo_App_ID.Text = "New App ID:       228512171129411";
            this.radioButton_Demo_App_ID.UseVisualStyleBackColor = true;
            this.radioButton_Demo_App_ID.CheckedChanged += new System.EventHandler(this.radioButton_Demo_App_ID_CheckedChanged);
            // 
            // DiscoverMeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.pictureBox_login_btn);
            this.Controls.Add(this.pictureBox_Login_bgnd);
            this.MaximizeBox = false;
            this.Name = "DiscoverMeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login_bgnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_btn)).EndInit();
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Login_bgnd;
        private System.Windows.Forms.PictureBox pictureBox_login_btn;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.TextBox textBox_Custom_App_ID;
        private System.Windows.Forms.RadioButton radioButton_Custom_App_ID;
        private System.Windows.Forms.RadioButton radioButton_My_New_App_ID;
        private System.Windows.Forms.RadioButton radioButton_Demo_App_ID;
    }
}
