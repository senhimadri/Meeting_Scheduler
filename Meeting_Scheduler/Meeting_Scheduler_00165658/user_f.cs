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
    public partial class user_f : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public user_f()
        {
            InitializeComponent();
        }
        public string indexs;
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usrprofile_f uf = new usrprofile_f();

            uf.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_activity_f af = new user_activity_f();
            af.Show();
        }
        private void comboitems()
        {





            int a = gloval.my_user_id;


            var data = DB.MeetAttendies.Where(x => x.u_id == a);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.ToList();



        }

        private void user_f_Load(object sender, EventArgs e)
        {
            comboitems();

            var data = DB.Calenders.Where(d => d.c_Id == 1).FirstOrDefault();

            if (data != null)
            {

                return;
            }

            for (int i = 0; i < 365; i++)
            {


                Calender cal = new Calender();


                cal.cDate = DateTime.Now.AddDays(i);
                DayOfWeek z = cal.cDate.Value.DayOfWeek;
                cal.wDay = z.ToString();
                cal.wNo = (cal.cDate.Value.Day / 7) + 1;
                cal.wHour = 8;
                if (cal.wDay == "Friday")
                {
                    cal.isHoliday = true;
                }
                else
                {
                    cal.isHoliday = false;
                }
                DB.Calenders.Add(cal);
                DB.SaveChanges();
            }




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            indexs = selectedRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       


            
        }
    }
}
