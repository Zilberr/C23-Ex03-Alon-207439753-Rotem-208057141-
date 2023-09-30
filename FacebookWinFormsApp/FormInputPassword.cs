using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public sealed partial class FormInputPassword : Form
    {
        private static FormInputPassword s_Form;
        private static readonly object sr_LockObject = new object();
        private string m_Password;
        private bool m_IsFirstTime = true;
        private FormInputPassword()
        {
            InitializeComponent();
        }
        public static FormInputPassword GetInstance()
        {
            if (s_Form == null)
            {
                lock (sr_LockObject)
                {
                    if (s_Form == null)
                    {
                        s_Form = new FormInputPassword();
                    }
                }
            }

            return s_Form;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = passwordTextBox.Text;
            passwordTextBox.Clear();

            if (m_IsFirstTime)
            {
                m_Password = enteredPassword;
                MessageBox.Show("Password saved successfully.");
                m_IsFirstTime = false;
                instructionLabel.Text = "Enter your password:";
                Close();
            }
            else
            {
                if (enteredPassword == m_Password)
                {
                    MessageBox.Show("Password is correct. You can proceed.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password is incorrect. Please try again.");
                    passwordTextBox.Clear();
                }
            }

        }
    }
}


