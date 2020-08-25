using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduler_00165658
{
    public partial class Login_f : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public Login_f()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = DB.Users.Where(a => a.uName == textBox1.Text && a.Pass == textBox2.Text).FirstOrDefault();

            gloval.my_user_id = data.u_Id; 

            if (data != null)
            {
                
                

                if (data.Role_Id == 1)
                {
                    user_f f4 = new user_f();
                    f4.Show();
                    
                }
                else
                {
                    admin f3 = new admin();
                    f3.Show();

                }
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invali users!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_f rf = new register_f();

            rf.Show();


        }

        private void Login_f_Load(object sender, EventArgs e)
        {
            var data = DB.Users.Where(y => y.Role_Id == 0).FirstOrDefault();

            if (data == null)
            {
                User u = new User()

                {
                    uName = "admin",

                    Job_Title = "Manager",
                    Pay_Grade = "A",
                    Gender = "Male",
                    Pass = "admin",
                    Role_Id = 0,
                    Age = "20"

                };

                DB.Users.Add(u);
                DB.SaveChanges();

            }

  
        
            
        }
    }
}
