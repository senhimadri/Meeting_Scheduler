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
   
   
    public partial class user_activity_f : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public user_activity_f()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = DB.Calenders.Where(x => x.cDate == dateTimePicker1.Value.Date).FirstOrDefault();



            int cal_id = data.c_Id;
            int UU = gloval.my_user_id;

            urActivity VV = new urActivity()

            {
                U_Id = UU,
                c_Id = cal_id,
                a_Title = textBox4.Text,
                s_Time = comboBox1.SelectedIndex,

                Duration = Int32.Parse(textBox2.Text),
                Presence = textBox1.Text





            };

            DB.urActivities.Add(VV);
            DB.SaveChanges();

            MessageBox.Show("Activity Is Added");
        }

        private void user_activity_f_Load(object sender, EventArgs e)
        {
            
        }
    }
}
