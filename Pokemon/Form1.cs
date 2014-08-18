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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                MongoClient client = new MongoClient("mongodb://Application:mm3LhteFxx8Q@ds063449.mongolab.com:63449/pokemon");
                var server = client.GetServer();

                var db = server.GetDatabase("pokemon");

                var collection = db.GetCollection<Type>("types");

                MongoCollection<Type> typesCollecton = collection;

                StringBuilder sb = new StringBuilder();

                foreach ( Type t in typesCollecton.FindAll())
                {
                    sb.Append(t.index + ": " + t.name + "\n");
                }

                MessageBox.Show(sb.ToString());

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
