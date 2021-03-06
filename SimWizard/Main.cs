using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimWizard
{
    public partial class Main : Form
    {

        List<SpecialSim> sim = new List<SpecialSim>();
        List<Balance> balance = new List<Balance>();

        //public void PerformRefresh()
        //{
        //    tbSimSearch.Text = "";
        //    datagridFill();
        //}

        public void read()
        {
            StreamReader sr = new StreamReader("SimList.csv", System.Text.Encoding.UTF8);

            string[] tmp;

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine().Split(';');
                SpecialSim sims = new SpecialSim();

                sims.ID = tmp[0];
                sims.Pin = tmp[1];
                //sims.Balance = tmp[2];
                sims.Status = tmp[2];
                sims.Type = tmp[3];
                if (tmp[4].Length != 0)
                {
                    sims.Puk = tmp[4];
                }
                sims.NumberOfActivations = Convert.ToInt32(tmp[5]);
                sims.Name = tmp[6];
                sims.ValidFrom = Convert.ToDateTime(tmp[7]);

                sim.Add(sims);
            }

            sr.Close();

        }

        public void readBalance()
        {
            StreamReader sr = new StreamReader("Balance.csv", System.Text.Encoding.UTF8);
            string[] tmp;

            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine().Split(';');
                Balance balances = new Balance();

                balances.ID = tmp[0];
                balances.Volume = Convert.ToInt32(tmp[1]);
                balances.Date = Convert.ToDateTime(tmp[2]);

                balance.Add(balances);
            }

            sr.Close();

        }

        public void datagridFill()
        {

            dgSim.DataSource = null;
            dgBalance.DataSource = null;

            if (tbSimSearch.TextLength == 0)
            {
                dgSim.DataSource = sim.Select(s => new { ID = s.ID, Status = s.Status, Type = s.Type, Name = s.Name }).ToList();
                dgBalance.DataSource = balance.GroupBy(x => x.ID).Select(s => new { ID = s.Key, Balance = s.Sum(x => x.Volume) }).ToList();
            }
            else
            {
                dgSim.DataSource = sim.Where(s => s.ID == tbSimSearch.Text).Select(s => new { ID = s.ID, Status = s.Status, Type = s.Type, Name = s.Name }).ToList();
                dgBalance.DataSource = balance.Where(s => s.ID == tbSimSearch.Text).Select(s => new { ID = s.ID, Date = s.Date.ToString("yyyy.MM.dd"), Volume = s.Volume }).ToList();
            }

        }

        public void datagridFill(string type)
        {

            dgSim.DataSource = null;
            dgBalance.DataSource = null;

            dgSim.DataSource = sim.Select(s => new { ID = s.ID, Status = s.Status, Type = s.Type, Name = s.Name }).Where(s => s.Type == type).ToList();
            //dgBalance.DataSource = balance.GroupBy(x => x.ID).Select(s => new { ID = s.Key, Balance = s.Sum(x => x.Volume) }).ToList();


        }


        public void addModify()
        {
            //SimAdd oForm = new SimAdd(this);
            //oForm.Show();

            if (tbSimSearch.Text != "")
            {
                SimAdd simadd = new SimAdd(tbSimSearch.Text, sim, balance);
                simadd.ShowDialog();
            }
            else
            {
                SimAdd simadd = new SimAdd(sim, balance);
                simadd.ShowDialog();
            }

        }

        public Main()
        {

            InitializeComponent();
            read();
            readBalance();

        }

        private void controllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimAdd simadd = new SimAdd(sim, balance);
            simadd.ShowDialog();
        }

        private void btSimSearch_Click(object sender, EventArgs e)
        {
            datagridFill();
        }

        private void btSimAdd_Click(object sender, EventArgs e)
        {

            addModify();
        }

        private void dgSim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = dgSim.Rows[index];
            tbSimSearch.Text = selectedRow.Cells[0].Value.ToString();
            datagridFill();
        }

        private void dgSim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbSimSearch.Clear();
                datagridFill();
            }

            if (e.KeyCode == Keys.Delete)
            {
                tbSimSearch.Clear();
                datagridFill();
            }

        }

        private void dgSim_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addModify();
        }

    }
}
