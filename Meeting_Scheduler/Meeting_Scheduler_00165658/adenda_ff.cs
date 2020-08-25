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
    public partial class adenda_ff : Form
    {
        public adenda_ff()
        {
            InitializeComponent();
        }
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            Agendum a = new Agendum()

            {
                Title = textagtitle.Text,
                Description = textag_des.Text,
                Type = combotype.Text


            };

            DB.Agenda.Add(a);
            DB.SaveChanges();

            MessageBox.Show("Agenda Is Created");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Agenda.ToList();

        }

        private void adenda_ff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Agenda.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
