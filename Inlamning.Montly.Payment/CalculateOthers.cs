using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning.Montly.Payment
{
    public partial class CalculateOthers : Form
    {

        private CalculateOthers calculateOthers { get; set; }
        private MainMenu mainMenu;
        public StreamingServices streamingServices;
        public MainMenu MainMenu
        {
            set
            {
                if (mainMenu != value)
                {
                    mainMenu = value;
                }
            }
        }
        public CalculateOthers()
        {
            InitializeComponent();
        }

        private void StrmToMnuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
        //Lägger till Nytt sparsmål, lägger sedan till sparsmålet i choosenlist.
        //Sedan läggs det till som ett nytt objekt.
        //Räknar ut månadssparandet.
        double newIncome = 0;
        double newCashGoal = 0;
        private void AddCostsButton_Click(object sender, EventArgs e)
        {
            string cashGoal = GoalTxtBox.Text;
            try
            {
                newCashGoal = Convert.ToDouble(cashGoal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to Add something!");
                return;

            }

            newCashGoal /= (double)TimePeriodNumeric.Value;


            if (GoalTxtBox.Text != null && TimePeriodNumeric.Value >= 0)
            {
                streamingServices.GetChosenList().Add(new Company("Saving", newCashGoal));
                CostCalcLabel.Visible = true;
                CostCalcLabel.Text = $"{GetChosenListValue().ToString("F2")} :-";
                financialGoalLabel.Visible = true;
                financialGoalLabel.Text = $"You need to save {newCashGoal.ToString("F2")}:- each month.";
                listBox1.Items.Clear();
                UpdateListBox();
            }

            GoalTxtBox.Clear();
        }
        double totalCost = 0;

        //väljer tidshorisont i sparsmålet
        private void TimePeriodNumeric_ValueChanged(object sender, EventArgs e)
        {
            TimePeriodNumeric.Minimum = 1;
            TimePeriodNumeric.Maximum = 12000;
            double timePeriod = 0;
            timePeriod = (double)TimePeriodNumeric.Value;
        }
        //Lägger till i Listboxen från chosenList.
        public void UpdateListBox()
        {
            foreach (Company services in streamingServices.GetChosenList())
            {
                listBox1.Items.Add(services);
            }
        }

        private void CalcTotButton_Click(object sender, EventArgs e)
        {
            if (IncomeTxtBox.Text != "")
            {
                string income = IncomeTxtBox.Text;
                IncomeTxtBox.Clear();
                try
                {
                    newIncome = Convert.ToDouble(income);
                }
                catch
                (Exception ex)
                { }
                newIncome -= GetChosenListValue();
                MoneyLeftLabel.Text = $"{newIncome.ToString("F2")} :-";

                MoneyLeftLabel.Visible = true;
                label5.Visible = true;
                ErrorLabel.Visible = false;
            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Invalid values";
            }
        }

        //Tar bort från ListBox samt chosenList
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Company selectedCompany)
            {
                listBox1.Items.Remove(selectedCompany);
                streamingServices.GetChosenList().Remove(selectedCompany);
            }
            else
            {
                MessageBox.Show("Choose item to remove");
            }
            CostCalcLabel.Text = GetChosenListValue().ToString("F2");
            financialGoalLabel.Text = GetChosenListValue().ToString();
        }

        //Få värdet av den valda listan
        public double GetChosenListValue()
        {
            double updatedCost = 0;
            foreach (Company company in streamingServices.GetChosenList())
            {
                updatedCost += company.Price;
            }

            return updatedCost;
        }
    }
}
//