using Microsoft.VisualBasic;
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
    public partial class SimAdd : Form
    {

        //List<Sim> sims = new List<Sim>();
        internal List<SpecialSim> sim2 = new List<SpecialSim>();
        List<SpecialSim> simCopy = new List<SpecialSim>();
        List<Balance> balanceCopy = new List<Balance>();    
        public string simIDCopy;
        public bool correctSim = false;

        public void save()
        {

            StreamWriter sw = new StreamWriter("SimList.csv", false);

            foreach (var item in simCopy)
            {
                sw.WriteLine(item.ID + ";" + item.Pin + ";" + item.Status + ";" + item.Type + ";" + item.Puk + ";" + item.NumberOfActivations + ";" + item.Name + ";" + item.ValidFrom);
            }

            sw.Close();


            StreamWriter sw2 = new StreamWriter("Balance.csv", false);

            foreach (var item in balanceCopy)
            {
                sw2.WriteLine(item.ID + ";" + item.Volume + ";" + item.Date);
            }

            sw2.Close();
        }


        public void delete()
        {

            MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                simCopy.RemoveAll(s => s.ID == simIDCopy);
                balanceCopy.RemoveAll(s => s.ID == simIDCopy);
                save();
                MessageBox.Show("Item is succesfully removew", "Delete", MessageBoxButtons.OK);

                if (DialogResult == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }

        }

        internal SimAdd(string simID, List<SpecialSim> simtmp, List<Balance> balancetmp)
        {
            simCopy = simtmp;
            simIDCopy = simID;
            balanceCopy = balancetmp;   
            var a = simtmp.Where(s => s.ID == simID).Select(s => new { ID = s.ID, Status = s.Status, Type = s.Type, s.Pin, s.Puk, s.Name, s.ValidFrom }).ToList();
            var b = balancetmp.Where(s => s.ID == simID).GroupBy(s => s.ID).Select(s => new {ID = s.Key, Balance = s.Sum(x => x.Volume)}).ToList();
            InitializeComponent();

            foreach (var item in a)
            {
                tbID.Text = item.ID;
                tbID.ReadOnly = true;
                tbName.Text = item.Name;
                tbName.ReadOnly = true;
                tbCreationDate.Text = item.ValidFrom.ToString("yyyy.MM.dd");
                tbCreationDate.ReadOnly = true;
                cbStatus.Text = item.Status;
                cbStatus.Enabled = false;
                cbType.Text = item.Type;
                cbType.Enabled = false;
                tbBalanceChange.ReadOnly = true;
                mtbPin.Text = item.Pin;
                mtbPin.Enabled = false;
                mtbPin.Visible = false;
                mtbPuk.Text = item.Puk;
                mtbPuk.Enabled = false;
                mtbPuk.Visible = false;
            }

            if (simIDCopy != null)
            {
                lbActual.Text = Convert.ToString(b[0].Balance);
            }
            
        }
        
        public void pinCheck()
        {

            if (simIDCopy != null)
            {

                var a = simCopy.Where(s => s.ID == simIDCopy).Select(s => new { ID = s.ID, Status = s.Status, Type = s.Type, s.Pin, s.Puk, s.NumberOfActivations }).ToList();

                int pin_counter = 0;


                //Special or not, activated or not
                if (Convert.ToInt32(a[0].NumberOfActivations) == 0)
                {
                    //Asking for Pin 3 times
                    while (pin_counter < 3)
                    {

                        string pin = Interaction.InputBox("Pin:");

                        //Pin not correct
                        if (pin != a[0].Pin)
                        {
                            MessageBox.Show("Pin code is incorrect! Try again", "Pin check", MessageBoxButtons.OK);
                            pin_counter++;
                        }
                        else if (pin == a[0].Pin) //Pin correct and counter is 0
                        {
                            tbID.ReadOnly = true;
                            tbName.ReadOnly = false;
                            cbStatus.Enabled = true;
                            tbBalanceChange.ReadOnly = false;
                            cbType.Enabled = true;
                            mtbPin.Visible = true;
                            mtbPin.Enabled = true;

                            correctSim = true;

                            break;
                        }

                        //After 3 try deactivate the SIM and store the failure
                        if (pin_counter == 2)
                        {
                            foreach (var item in simCopy.Where(s => s.ID == simIDCopy))
                            {
                                item.NumberOfActivations = item.NumberOfActivations + 1;
                                item.Status = "Inactive";
                                save();
                                this.Close();
                            }
                        }
                    }
                }
                else if (a[0].Type == "Normal" && Convert.ToInt32(a[0].NumberOfActivations) != 0)
                {
                    MessageBox.Show("This SIM is permanently banned!", "Deactivated SIM", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (a[0].Type == "Special" && Convert.ToInt32(a[0].NumberOfActivations) == 1)//If SIM inactive, Special and there was a try, then PUK needed
                {
                    while (pin_counter < 3)
                    {
                        string puk = Interaction.InputBox("PUK:");

                        //Pin not correct
                        if (puk != a[0].Puk)
                        {
                            pin_counter++;
                            MessageBox.Show("Puk code is incorrect! Try again", "Puk check", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else if (puk == a[0].Puk) //Puk correct
                        {
                            tbID.ReadOnly = true;
                            tbName.ReadOnly = false;
                            cbStatus.Enabled = true;
                            tbBalanceChange.ReadOnly = false;
                            cbType.Enabled = true;
                            mtbPin.Visible = true;
                            mtbPin.Enabled = true;
                            mtbPuk.Visible = true;
                            mtbPuk.Enabled = true;

                            correctSim = true;

                            break;
                        }

                        //After 3 try deactivate the SIM and store the failure
                        if (pin_counter == 2)
                        {
                            foreach (var item in simCopy.Where(s => s.ID == simIDCopy))
                            {
                                item.NumberOfActivations = item.NumberOfActivations + 1;
                                item.Status = "Inactive";
                                save();
                                this.Close();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("This SIM is permanently banned!", "Deactivated SIM", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("You don't have any item to modify!", "No active Item", MessageBoxButtons.OK);
            }

        }

        internal SimAdd(List<SpecialSim> simtmp, List<Balance> balancetmp)
        {
            simCopy = simtmp;
            balanceCopy = balancetmp;
            InitializeComponent();

            lbPuk.Visible = false;
            mtbPuk.Visible = false;
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
           
                if (simCopy.Any(s => s.ID.Contains(tbID.Text)) && simIDCopy == null)
                {
                    MessageBox.Show("This ID is already taken.","Used ID", MessageBoxButtons.OK);
                }
                else
                {
                    simCopy.RemoveAll(s => s.ID == simIDCopy);

                    string[] newsim = new string[] { tbID.Text, mtbPin.Text, cbStatus.SelectedItem.ToString(), cbType.SelectedItem.ToString(), mtbPuk.Text, "0", tbName.Text, tbCreationDate.Text, tbBalanceChange.Text };

                    SpecialSim sims = new SpecialSim();
                    Balance balances = new Balance();

                    sims.ID = newsim[0];
                    sims.Pin = newsim[1];
                    sims.Status = newsim[2];
                    sims.Type = newsim[3];
                    sims.Puk = newsim[4];
                    sims.NumberOfActivations = Convert.ToInt32(newsim[5]);
                    sims.Name = newsim[6];
                    sims.ValidFrom = Convert.ToDateTime(newsim[7]);

                    simCopy.Add(sims);

                    balances.ID = newsim[0];
                    balances.Date = DateTime.Now;
                    balances.Volume = Convert.ToInt32(newsim[8]);

                    balanceCopy.Add(balances);

                    save();
                    this.Close();
                }

        }

        private void btModify_Click(object sender, EventArgs e)
        {
            pinCheck();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbType.Text == "Special")
            {
                lbPuk.Visible = true;
                mtbPuk.Visible = true;
            }
            else
            {
                lbPuk.Visible = false;
                mtbPuk.Visible = false;
            }   
       
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (correctSim == true)
            {
                delete();
            }
            else
            {
                pinCheck();

                if (correctSim == true)
                {
                    delete();
                }
                
            }
           
        }
    }
}
