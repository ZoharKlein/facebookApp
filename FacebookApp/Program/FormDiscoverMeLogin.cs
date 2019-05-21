using System;
using System.Windows.Forms;

namespace Program
{
    public sealed partial class FormDiscoverMeLogin : Form
    {
        private FormDiscoverMeLogin()
        {
            InitializeComponent();
        }

        private static readonly object sr_InstanceLock = new object();
        private static FormDiscoverMeLogin s_Instance;
        private string m_AppId = null;

        public static FormDiscoverMeLogin Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FormDiscoverMeLogin();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public string AppID
        {
            get
            {
                return this.m_AppId;
            }

            set
            {
                if (m_AppId == null)
                {
                    this.m_AppId = value;
                }
            }
        }

        private void radioButton_Demo_App_ID_CheckedChanged(object sender, EventArgs e)
        {
            defaultAppSettings();
        }

        private void radioButton_My_New_App_ID_CheckedChanged(object sender, EventArgs e)
        {
            defaultAppSettings();
        }

        private void radioButton_Custom_App_ID_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Custom_App_ID.Enabled = true;
            textBox_Custom_App_ID.Text = string.Empty;
        }

        private void defaultAppSettings()
        {
            textBox_Custom_App_ID.Enabled = false;
            textBox_Custom_App_ID.Text = m_TextBoxCustomText;
        }

        private void pictureBox_login_btn_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox_Settings.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioB = (RadioButton)control;
                    if (radioB.Checked == true)
                    {
                        string radioBText = radioB.Text;

                        if (textBox_Custom_App_ID.Enabled == true)
                        {
                            radioBText = textBox_Custom_App_ID.Text;
                        }
                        else
                        {
                            radioBText = radioBText.Substring(radioBText.LastIndexOf(" "));
                        }

                        AppID = radioBText;
                        FormDiscoverMeMain formDiscoverMeMain = new FormDiscoverMeMain();
                        this.Hide();
                        formDiscoverMeMain.FormClosed += (s, args) => this.Close();
                        formDiscoverMeMain.Show();
                        formDiscoverMeMain.Focus();
                        break;
                    }
                }
            }
        }
    }
}
