using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning.Montly.Payment
{
    public partial class StreamingServices : Form
    {
        public StreamingServices streamingServices { get; set; }
        private MainMenu mainMenu;
        private CalculateOthers calculateOthers { get; set; }
        public static List<Company> CompanyList = new List<Company>();
        public static List<Company> choosenCompanysList = new List<Company>();

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
        public StreamingServices()
        {
            InitializeComponent();

            CompanyList.Add(new Company("Youtube Premium", 69));
            CompanyList.Add(new Company("Netflix", 119));
            CompanyList.Add(new Company("Amazon Prime", 59));
            CompanyList.Add(new Company("Disney+", 89));
            CompanyList.Add(new Company("HBO Max", 89));
            CompanyList.Add(new Company("CMore", 119));
            CompanyList.Add(new Company("CMore plus", 399));
            CompanyList.Add(new Company("AppleTV", 59));
            CompanyList.Add(new Company("TV4 play Plus+", 59));
            CompanyList.Add(new Company("Discovery+", 129));
            CompanyList.Add(new Company("Viaplay", 149));
            CompanyList.Add(new Company("Viaplay Sport", 379));
            CompanyList.Add(new Company("Viaplay Total", 549));
            CompanyList.Add(new Company("Apple Music", 119));
            CompanyList.Add(new Company("Spotify", 119));

            //Lägger till objekten i Listboxen.
            foreach (Company company in CompanyList)
            {
                CompanyListbox.Items.Add(company);
            }
        }
        //Tar användaren tillbaka till mainmenu och gömmer denna formen.
        private void StrmToMnuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
        double monthlyFee = 0;

        //Lägger till i både listboxen och listan.
        private void AddChsnButton_Click(object sender, EventArgs e)
        {

            if (CompanyListbox.SelectedItem is Company selectedcompany)
            {
                if (!ChosenListBox.Items.Contains(selectedcompany))
                {
                    choosenCompanysList.Add(selectedcompany);
                    ChosenListBox.Items.Add(selectedcompany);
                    monthlyFee += selectedcompany.Price;
                }
                else
                {
                    MessageBox.Show("You've already added that service!");
                }
            }
            KrMonthLabel.Text = $"{monthlyFee.ToString("F2")} :-";
            KrMonthLabel.Visible = true;
        }

        //Tar bort från ChosenListBox och subtraherar värdet från KrMonthLabel. 
        private void RmvCpnyButton_Click(object sender, EventArgs e)
        {
            if (ChosenListBox.SelectedItem is Company selectedcompany)
            {
                ChosenListBox.Items.RemoveAt(ChosenListBox.SelectedIndex);

                monthlyFee -= selectedcompany.Price;
                KrMonthLabel.Text = monthlyFee.ToString("F2");
            }
        }

        //Lägger till i listboxen samt listan
        private void AddCpnyButton_Click(object sender, EventArgs e)
        {
            string companyName = CompanyTextBox.Text;
            CompanyTextBox.Clear();
            string companyCost = CostTextBox.Text;
            CostTextBox.Clear();
            double newCost = 0;
            try
            {
                newCost = Convert.ToDouble(companyCost);
            }
            catch
            {
                MessageBox.Show("You can't use button without adding a company");
            }

            bool companyExists = false;

            for (int i = 0; i < choosenCompanysList.Count; i++)
            {
                if (companyName.ToLower() == choosenCompanysList[i].Name.ToLower())
                {
                    MessageBox.Show("You can't add the same service");
                    companyExists = true;
                    break;
                }

            }
            monthlyFee += newCost;

            if (!companyExists)
            {
                if (CompanyTextBox != null && CostTextBox != null)
                {
                    Company company = new Company(companyName, newCost);
                    choosenCompanysList.Add(company);
                    ChosenListBox.Items.Add(company);

                    KrMonthLabel.Visible = true;
                    KrMonthLabel.Text = $"{monthlyFee.ToString("F2")} :-";
                }
                else
                {
                    MessageBox.Show("Give Name:, and Cost:");
                }
            }
        }
        public double GetMonthlyFee()
        {
            return monthlyFee;
        }
        public List<Company> GetChosenList()
        {
            return choosenCompanysList;
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ChosenListBox.Items.Clear();
            double listPrice = 0;

            foreach (Company company in choosenCompanysList)
            {
                ChosenListBox.Items.Add((Company)company);
                listPrice += company.Price;
            }
            KrMonthLabel.Text = $"{listPrice.ToString("F2")} :-";
        }

        public void setChosenList(List<Company> list)
        {
            choosenCompanysList = list;
        }
    }
}
