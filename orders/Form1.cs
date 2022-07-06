using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            DataBase connect = new DataBase("mongodb://localhost:27017", "admin", "test");
            
            //testing
            //TextBox testText = urlField;
            //testText.Text = connect.Get1().ToString();
        }
    }
}