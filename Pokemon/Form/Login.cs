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
                var users = client.getCollection<Pokemon.Core.User>("users");

                Pokemon.Core.User u1 = users.AsQueryable<Pokemon.Core.User>().Single<Pokemon.Core.User>(u => ((u.UserName == txtUserName.Text) &&
                                                                                        (u.Password == txtPassword.Text)));

                MessageBox.Show(u1.id + "\n" + u1.UserName + " " + u1.Password);

                clearTextBoxes();
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show("Invalid login credentials!\nPlease try again.");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred!:\n" + ex.Message);
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
