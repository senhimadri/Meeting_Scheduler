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
    public partial class admin : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meeting_ff mf = new meeting_ff();

            mf.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adenda_ff af = new adenda_ff();

            af.Show();
        }

        private void venuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venue_ff vf = new venue_ff();
            vf.Show();
        }

        private void quarumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quorum_ff qf = new quorum_ff();
            qf.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvitePeople_Form ipf = new InvitePeople_Form();
            ipf.Show();
        }
    }
}
