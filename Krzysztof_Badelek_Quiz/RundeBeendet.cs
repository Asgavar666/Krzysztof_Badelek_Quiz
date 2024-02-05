using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krzysztof_Badelek_Quiz
{
    public partial class RundeBeendet : Form
    {
        public RundeBeendet()
        {
            InitializeComponent();
        }
        public void UpdatePoints(int punkte)
        {
            LbPunkte.Text = punkte.ToString();
        }
        

        private void BtnHighscore_Click(object sender, EventArgs e)
            {Datenbank datenbank = new Datenbank();
             DataSet ds = datenbank.PullDataFromDB();
             dataGridView1.DataSource = ds.Tables[0];

        }

       

    }
}
