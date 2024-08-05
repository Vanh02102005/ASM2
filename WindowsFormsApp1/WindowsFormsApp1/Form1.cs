using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly object cbTypesofcustomers;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvWaterBill.SelectedItems.Count > 0)
            {
                lsvWaterBill.Items.Remove(lsvWaterBill.SelectedItems[0]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvWaterBill.View = View.Details;
            lsvWaterBill.GridLines = true;
            lsvWaterBill.FullRowSelect = true;

            lsvWaterBill.Columns.Add("ID", 50);
            lsvWaterBill.Columns.Add("Name", 50);
            lsvWaterBill.Columns.Add("Phone", 50);
            lsvWaterBill.Columns.Add("Last Month", 70);
            lsvWaterBill.Columns.Add("This Month", 70);
            lsvWaterBill.Columns.Add("Types Of Customers", 120);
            lsvWaterBill.Columns.Add("Number Of Member ", 120);
            lsvWaterBill.Columns.Add("Description", 100);
        }

        private void lsvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem tempItem = lsvWaterBill.SelectedItems[0];
                string ID = tempItem.SubItems[0].Text;
                string Name = tempItem.SubItems[1].Text;
                string Phone = tempItem.SubItems[2].Text;
                string LastMonth = tempItem.SubItems[3].Text;
                string ThisMonth = tempItem.SubItems[4].Text;
                string Typesofcustomers = tempItem.SubItems[5].Text;
                string Numberofmember = tempItem.SubItems[6].Text;;
                string Description = tempItem.SubItems[7].Text;

                if (Typesofcustomers == "1.Household")
                {
                    cbTypes.SelectedIndex = 0;
                }
                else if (Typesofcustomers == "2.Administrative agency")
                {
                    cbTypes.SelectedIndex = 1;
                }
                else if (Typesofcustomers == "3.Production unit")
                {
                    cbTypes.SelectedIndex = 2;
                }
                else
                {
                    cbTypes.SelectedIndex = 3;
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            double Phone = double.Parse (txtPhone.Text);
            double LastMonth = double.Parse(txtLastMonth.Text);
            double ThisMonth = double.Parse(txtThisMonth.Text);
            string Typesofcustomers = null;
            string Member = txtMember.Text; 
            string Description = txtDescription.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please Enter ID Customer ", "Notice",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please Enter Customer Name ", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please Enter Phone Number", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(txtThisMonth.Text))
            {
                MessageBox.Show("Please Enter Amount Of Water Used This Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThisMonth.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastMonth.Text))
            {
                MessageBox.Show("Please Enter Amount Of Water Used Last Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastMonth.Focus();
            }


            if (cbTypes.SelectedIndex == 0)
            {
                Typesofcustomers = "Household";
                if (string.IsNullOrEmpty(Member))
                {
                    MessageBox.Show("Please Enter Number Of Members", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMember.Focus();
                    return;
                }
            }
            else if (cbTypes.SelectedIndex == 1)
            {
                Typesofcustomers = "Administrative agency";
            }
            else if (cbTypes.SelectedIndex == 2)
            {
                Typesofcustomers = " Production unit";
            }
            else if (cbTypes.SelectedIndex == 3)
            {
                Typesofcustomers = "Business service";
            }
            else
            {
                MessageBox.Show("Please enter Type of customer", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListViewItem item = new ListViewItem();
            item.Text = (ID);
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone.ToString());
            item.SubItems.Add(LastMonth.ToString());
            item.SubItems.Add(ThisMonth.ToString());
            item.SubItems.Add(Typesofcustomers);
            item.SubItems.Add(Member);
            item.SubItems.Add(Description);
            lsvWaterBill.Items.Add(item);


            
            if (ThisMonth < LastMonth)
            {
                MessageBox.Show("This month's meter reading must be greater than or equal to last month's reading.");
                return;
            }
            double Total = 0;
            double cost = 0;
            double Consumptions = 0;
            Consumptions = ThisMonth - LastMonth;
            if(Typesofcustomers == "Households")
            {             
                if (Consumptions < 10)
                {
                    cost = 5.073;
                    Total = Consumptions * 5.973;
                }
                else if (Consumptions >= 10 && Consumptions < 20)
                {
                    cost = 7.052;
                    Total = 10 * 5.973 + (Consumptions - 10) * 7.052; 
                }
                else if (Consumptions >= 20 && Consumptions <30)
                {
                    cost = 8.699;
                    Total = 10 * 5.973 + 10 * 7.052 + (Consumptions - 20) * 8.699;
                }
                else
                {
                    cost = 15.929;
                    Total = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (Consumptions - 30) * 15.929;
                }            
            }
            else if(Typesofcustomers == "Administrative agency")
            {
                Total = Consumptions * 9.955;
            }
            else if (Typesofcustomers == "Production unit")
            {
                Total = Consumptions * 11.615;
            }
            else
            {
                Total = Consumptions * 22.068;
            }
            double TotalBill = Total * 1.21;
            Form2 form2 = new Form2(  TotalBill);
            form2.Show();
        }
    

  
    
   


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvWaterBill.SelectedItems[0];
                item.SubItems.Clear();
                string ID = txtID.Text;
                string Name = txtName.Text;
                string Phone = txtPhone.Text;
                double LastMonth = double.Parse(txtLastMonth.Text);
                double ThisMonth = double.Parse(txtThisMonth.Text);
                string Typesofcustomers = null;
                string Member = txtMember.Text;
 
                string Description = txtDescription.Text;           
                if (string.IsNullOrEmpty(ID))
                {
                    MessageBox.Show("Please Enter ID Customer ", "Notice",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                }
                else if (string.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("Please Enter Customer Name ", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                }
                else if (string.IsNullOrEmpty(Phone))
                {
                    MessageBox.Show("Please Enter Phone Number", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                }
                else if (string.IsNullOrEmpty(txtLastMonth.Text))
                {
                    MessageBox.Show("Please Enter Amount Of Water Used Last Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastMonth.Focus();
                }
                else if (string.IsNullOrEmpty(txtThisMonth.Text))
                {
                    MessageBox.Show("Please Enter Amount Of Water Used This Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThisMonth.Focus();
                }

                double Total = 0;
                double cost = 0;
                double Consumptions = 0;
                Consumptions = ThisMonth - LastMonth;
                if (cbTypes.SelectedIndex == 0)
                {
                    Typesofcustomers = "Household";
                    if ( string.IsNullOrEmpty(Member))
                    {
                        MessageBox.Show("Please Enter Number Of Members", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMember.Focus();
                        return;
                    }                 
                    if (Consumptions < 10)
                    {
                        cost = 5.073;
                        Total = Consumptions * 5.973;
                    }
                    else if (Consumptions >= 10 && Consumptions < 20)
                    {
                        cost = 7.052;
                        Total = 10 * 5.973 + (Consumptions - 10) * 7.052;
                    }
                    else if (Consumptions >= 20 && Consumptions < 30)
                    {
                        cost = 8.699;
                        Total = 10 * 5.973 + 10 * 7.052 + (Consumptions - 20) * 8.699;
                    }
                    else
                    {
                        cost = 15.929;
                        Total = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (Consumptions - 30) * 15.929;
                    }
                }
                else if (cbTypes.SelectedIndex == 1)
                {
                    Typesofcustomers = "Administrative agency";
                    Total = Consumptions * 9.955;
                }
                else if (cbTypes.SelectedIndex == 2)
                {
                    Typesofcustomers = "Production unit";
                }
                else if (cbTypes.SelectedIndex == 3)
                {
                    Typesofcustomers = "Business service";
                }
                else
                {
                    MessageBox.Show("Please enter Type of customer", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(LastMonth.ToString());
                item.SubItems.Add(ThisMonth.ToString());
                item.SubItems.Add(Typesofcustomers);
                item.SubItems.Add(Member);
                item.SubItems.Add(Description);

                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            txtLastMonth.Text = null;
            txtThisMonth.Text = null;
            txtMember.Text = null;
            cbTypes.SelectedIndex = -1;
            txtDescription.Text = null;
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
 
        }
    }
}
