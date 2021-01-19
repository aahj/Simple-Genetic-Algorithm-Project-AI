using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA__windowsForm_project
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();                                    
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJNK07D\SQLEXPRESS2;Initial Catalog=AI_Project;Integrated Security=True");        

        private void Form2_Load(object sender, EventArgs e)
        {            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 100);

            if (Isvalid())
            {
                SqlCommand cmd = new SqlCommand("insert into signUp_user values(@userId,@email,@password) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userId", random);
                cmd.Parameters.AddWithValue("@email", email_inp.Text);
                cmd.Parameters.AddWithValue("@password", pass_inp.Text);                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully inserted data into database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }

        }

        public void clear()
        {
            email_inp.Text = "";
            pass_inp.Text = "";
        }
        private bool Isvalid()
        {
            if (email_inp.Text == "" && pass_inp.Text == "")
            {
                MessageBox.Show("Email and Password are required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select email,password from signUp_user where email = '" + email_inp.Text + "' and password ='" + pass_inp.Text + "'", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully Login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass_inp.Text = "";
            }

        }
    }
}

