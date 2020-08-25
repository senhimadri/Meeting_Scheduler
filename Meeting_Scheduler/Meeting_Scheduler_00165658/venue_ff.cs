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
    public partial class venue_ff : Form
    {
        DB_MS_ADIEntities DB = new DB_MS_ADIEntities();
        public venue_ff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Venu v = new Venu()

            {

                vName = textvname.Text,
                vLocation = textvloca.Text,
                vAddress = textvaddre.Text,
                Capacity = Int32.Parse(textvcapasity.Text)




            };

            DB.Venus.Add(v);
            DB.SaveChanges();

            MessageBox.Show("Venu Is Created");
        }

        private void venue_ff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Venus.ToList();
        }
    }
}
