using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning.Montly.Payment
{
    public partial class MainMenu : Form
    {
        StreamingServices streamingServices = new StreamingServices();
        CalculateOthers calculateOthers = new CalculateOthers();
        public MainMenu()
        {
            InitializeComponent();
            streamingServices.MainMenu = this;
            calculateOthers.streamingServices = streamingServices;
            calculateOthers.MainMenu = this;

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program ended...");
            Application.Exit();
        }
        private void ChooseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            streamingServices.BringToFront();
            streamingServices.ShowDialog();
            LoadedCostLabel.Visible = false;
            LoadedLabel.Visible = false;
            listBox1.Visible = false;
            label3.Visible = false;
        }

        //updateknappen skickar med värdet från den valda listan till MainMenu.

        private void UpdateCostButton_Click(object sender, EventArgs e)
        {
            CostLabel.Visible = true;
            calculateOthers.GetChosenListValue();
            CostLabel.Text = $"{calculateOthers.GetChosenListValue().ToString("F2")} :-";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculateOthers.BringToFront();
            calculateOthers.ShowDialog();
            LoadedCostLabel.Visible = false;
            LoadedLabel.Visible = false;
            listBox1.Visible = false;
            label3.Visible = false;
        }
        string folderPath = "costFolder";
        string path = "costFolder/costs.csv";
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadedCostLabel.Visible = true;
            LoadedLabel.Visible = true;
            listBox1.Visible = true;
            label3.Visible = true;
            LoadCompanys();
        }
        //skapar en fil om den inte existerar? 
        //När den existerar så lägger den till innehållet av den valda listan???
        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(folderPath);
            File.Delete(path);

            //skriver in i csv filen.
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Company company in streamingServices.GetChosenList())
                {
                    sw.WriteLine(company.GetCSV());
                }
            }
        }
        //Läser in filen användaren sparat ner.  
        private void LoadCompanys()
        {
            List<Company> list = new List<Company>();
            listBox1.Items.Clear();
            list.Clear();

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                using (StreamReader sr = new StreamReader(path))
                {

                    string line = sr.ReadLine();


                    double costLabel = 0;
                    while (line != null)
                    {
                        string[] strings = line.Split(',');

                        string name = strings[0];
                        double cost = double.Parse(strings[1]);

                        Company company = new Company(name, cost);
                        list.Add(company);

                        listBox1.Items.Add(company.Name + " ," + company.Price + ":-");

                        costLabel += company.Price;
                        LoadedCostLabel.Text = $"{costLabel.ToString("F2")} :-";

                        line = sr.ReadLine();

                    }

                    streamingServices.setChosenList(list);
                }
            }
            else
            {
                MessageBox.Show("You need to save something first");
            }
        }

    }
}