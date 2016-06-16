using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace censorapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon ;
            MySqlCommand cmd = new MySqlCommand();
            string fn=fname.Text;
            string mn = mname.Text;
            string ln = lname.Text;
            string se = sex.Text;
            string ms = maritalstatus.Text;
            DateTime dateob = dob.Value;
            string em = email.Text;
            string phnnum = phonenumber.Text;
            string sor = stateoforigin.Text;
            string nat = nationality.Text;
            string es = employmentstatus.Text;
            string ws = worksector.Text;
            string oa = officeaddress.Text;
            string connection = "server= localhost; username=root; password=root; database=censordb;";
            mycon = new MySqlConnection(connection);
            try
            {
                mycon.Open();
                
              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "INSERT INTO censortable VALUES ('',@fns,@mn,@ln,@se,@ms,@dateob,@em,@phnnum,@sor,@nat,@es,@ws,@oa)";
            cmd.Parameters.AddWithValue("@fns", fn);
            cmd.Parameters.AddWithValue("@mn", mn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@se", se);
            cmd.Parameters.AddWithValue("@ms", ms);
            cmd.Parameters.AddWithValue("@dateob", dateob);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@phnnum", phnnum);
            cmd.Parameters.AddWithValue("@sor", sor);
            cmd.Parameters.AddWithValue("@nat", nat);
            cmd.Parameters.AddWithValue("@es", es);
            cmd.Parameters.AddWithValue("@ws", ws);
            cmd.Parameters.AddWithValue("@oa", oa);
            cmd.CommandText = query;
            cmd.Connection = mycon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            fname.Text = "";
            mname.Text = "";
            lname.Text = "";
            sex.Text = "";
            maritalstatus.Text = "";
            dob.Text = "";
            email.Text = "";
            phonenumber.Text = "";
            stateoforigin.Text = "";
            nationality.Text = "";
            employmentstatus.Text = "";
            worksector.Text = "";
            officeaddress.Text = "";

           


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myf2 = new Form2();
            myf2.ShowDialog();
            this.Close();

        }
    }
}
