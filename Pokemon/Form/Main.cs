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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (Globals.login.Developer)
                tslblUserName.ForeColor = Color.Blue;

            tslblUserName.Text = Globals.login.ToString();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgChangePassword dlg = new dlgChangePassword();
            dlg.Show();
        }
    }
}
