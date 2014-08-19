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
        public Login()
        {
            InitializeComponent();

            try
            {
                Pokemon.Model.Client c = new Pokemon.Model.Client();
                MongoCollection<Pokemon.Core.User> userCollection = c.getCollection<Pokemon.Core.User>("users");

                StringBuilder sb = new StringBuilder();

                foreach ( Pokemon.Core.User u in userCollection.FindAll())
                {
                    sb.Append(u.UserName + ": " + u.Developer.ToString() + "\n");
                }

                MessageBox.Show(sb.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: \n" + ex.Message);
            }
        }
    }
}
