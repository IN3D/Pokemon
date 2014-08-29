using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon.Model;
using MongoDB.Driver.Builders;

namespace Pokemon
{
    public partial class dlgChangePassword : Form
    {
        public dlgChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Security.validatePassword(txtOldPassword.Text, Globals.login.Password))
            {
                if (txtNewPassword.Text == txtConfirm.Text)
                {
                    try
                    {
                        string newPass = Security.createHash(txtNewPassword.Text);

                        Client client = new Client();
                        var userCollection = client.getCollection<Pokemon.Core.User>("users");

                        Globals.login.Password = newPass;

                        Globals.login.updatePassword();

                        MessageBox.Show("Password successfully changed!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The new password you entered did not match the confirmation.\nPlease try again.");
                }
            }
            else
            {
                MessageBox.Show("Sorry, the password you entered does not match your current one.\nPlease try again.");
            }
        }
    }
}
