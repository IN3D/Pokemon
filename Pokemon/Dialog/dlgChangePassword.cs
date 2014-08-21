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
            string oldPassHashedAndSalted = (Globals.login.Salt + Security.generateHash(txtOldPassword.Text));

            if (oldPassHashedAndSalted == (Globals.login.Salt + Globals.login.Password))
            {
                if (txtNewPassword.Text == txtConfirm.Text)
                {
                    try
                    {
                        string newSalt = Security.getSalt(10);
                        Globals.login.Password = (Security.getPoint() + newSalt + Security.generateHash(txtNewPassword.Text));
                        Globals.login.Salt = newSalt;

                        Client client = new Client();

                        var userCollection = client.getCollection<Pokemon.Core.User>("users");

                        userCollection.Save<Pokemon.Core.User>(Globals.login);
                        Globals.login.Password = Globals.login.Password.Remove(0, 4);

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
