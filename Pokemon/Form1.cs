using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // mongoDB test
            try
            {
                //MessageBox.Show("Success, for now...");

                MongoClient client = new MongoClient("mongodb://Application:mm3LhteFxx8Q@ds063449.mongolab.com:63449/pokemon");
                var server = client.GetServer();
                var db = server.GetDatabase("pokemon");

                var collection = db.GetCollection<Type>("types");

                MongoCollection<Type> types = db.GetCollection<Type>("types");

                foreach (Type t in types.FindAll())
                {
                    listBox1.Items.Add(t.index + ": " + t.name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("failed!\n" + ex.ToString());
            }

        }


    }
}
