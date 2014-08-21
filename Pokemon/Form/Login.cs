using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Communication;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using Pokemon.Model;

namespace Pokemon
{
    public partial class Login : Form
    {
        Pokemon.Model.Client client = new Pokemon.Model.Client();

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string passHash = Pokemon.Model.Security.generateHash(txtPassword.Text);

                var users = client.getCollection<Pokemon.Core.User>("users");

                Pokemon.Core.User user = new Pokemon.Core.User();
                foreach (Pokemon.Core.User u in users.FindAllAs<Pokemon.Core.User>())
                {
                    if (u.UserName.ToLower() == txtUserName.Text.ToLower() && (u.Password.Remove(0, 4) == u.Salt + passHash))
                    {
                        user.copyAssignment(u);
                        break;
                    }
                }
                clearTextBoxes();

                if (user.UserName != null && user.Password != null)
                {
                    Globals.login.copyAssignment(user);

                    Main m = new Main();
                    this.Hide();

                    // open main, and set it to be
                    // the main form.
                    m.ShowDialog();

                    // clean up and close.
                    m = null;
                    this.Close();
                }
                else
                {
                    // this should never happen, the catch
                    // should intervene before this...
                    MessageBox.Show("Something has gone very wrong and the program needs to exit.");

                    // something is very wrong, terminate everything...
                    System.Windows.Forms.Application.Exit();
                }
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show("Invalid login credentials!\nPlease try again.");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);
                clearTextBoxes();
            }
        }

        private void clearTextBoxes()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
