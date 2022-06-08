using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneRecords
{
    public partial class Form1 : Form
    {
        private List<Record> records = new List<Record>();
        private List<Record> filtered = new List<Record>();
        private string nameFilter = "";
        private string codeFilter = "";
        private DateTime? dateFilter = null;
        private string total = "";

        public Form1()
        {
            InitializeComponent();
            LoadRecords();

            InitializeListView();
            UpdateListViewData();
        }

        private void InitializeListView()
        {
            this.listView1.View = View.Details; 
            this.listView1.FullRowSelect = true;
            listView1.Columns.Add("Дата");
            listView1.Columns.Add("Ім'я");
            listView1.Columns.Add("Нас. пункт");
            listView1.Columns.Add("Код");
            listView1.Columns.Add("Тривалість (хв.)");
            listView1.Columns.Add("Тариф (коп./хв.)");
            listView1.Columns.Add("Номер"); 
            listView1.GridLines = true;
        }

        private void ApplyFilters()
        {
            filtered = records;
            nameFilter = this.localityName.Text.Trim();
            codeFilter = this.localityCode.Text.Trim();
            if (checkBox1.Checked)
            {
                dateFilter = dateTimePicker1.Value.Date;
            }
            else
            {
                dateFilter = null;
            }
            if (nameFilter != String.Empty)
                filtered = filtered
                    .Where(x => x.City.Contains(nameFilter))
                    .ToList();
            if (codeFilter != String.Empty)
                filtered = filtered
                    .Where(x => x.Code.Contains(codeFilter))
                    .ToList();
            if (dateFilter != null)
                filtered = filtered
                    .Where(x => x.Date.Date == ((DateTime)dateFilter).Date)
                    .ToList();
            UpdateTotal();
        }
       
        private void UpdateTotal()
        {
            total = "Підсумок:\n";
            var date = dateTimePicker1.Value;
            var dateRecords = records.ToList();
            //.Where(r => r.Date.Date == date.Date)
            var longestCity = dateRecords.GroupBy(x => x.City)
                .Select(g => new
                {
                    city = g.Key,
                    duration = g.Sum(x => x.Duration)
                })
                .OrderByDescending(x => x.duration)
                .FirstOrDefault();
            if (longestCity == null)
            {
                total += $"\nЗа дату {date.ToShortDateString()} не було здійснено\n жодного дзвінка.";
           
            }
            else
            {
                total += $"\nнайбільше говорили у { longestCity.city} ({ longestCity.duration-50}хв)";
                //total += $"\nЗа дату {date.ToShortDateString()} \nнайбільше говорили у {longestCity.city} ({longestCity.duration-50}хв)";
                string cityName = "";
                if (listView1.SelectedItems.Count > 0)
                {
                    var selected = listView1.Items[listView1.SelectedIndices[0]];
                    cityName = selected.SubItems[2].Text;
                }
                else if (nameFilter != String.Empty)
                {
                    cityName = nameFilter;
                }
                if (cityName != String.Empty)
                {
                    var cityRecords = records.Where(r => r.City == cityName && r.Date.Date == date.Date).ToList();
                    int count = cityRecords.Count;
                    int totalDuration = cityRecords.Sum(x => x.Duration);
                    decimal totalPrice = cityRecords.Sum(x => x.Duration * x.Tarif) / 100m;
                    total += $"\n\nУ місті {cityName} за дату {date.ToShortDateString()} \nбуло здійснено {count} дзвінків \nсумарною довжиною {totalDuration}c \nта вартістю {totalPrice}грн.";
                }
            }

            if (total != String.Empty)
            {
                totalLabel.Text = total;
                totalLabel.Visible = true;
            }
        }

        private void UpdateListViewData()
        {
            listView1.Items.Clear();
            foreach (var r in filtered)
            {
                listView1.Items.Add(new ListViewItem(new String[]
                {
                    r.Date.ToString(),
                    r.Name,
                    r.City,
                    r.Code,
                    r.Duration.ToString(),
                    r.Tarif.ToString(),
                    r.Number
                }));
            }
        }

        private void LoadRecords()
        {
            string filename = "example-data.csv";
            string fileData = File.ReadAllText(filename);
            var cells = fileData
                .Split(new string[] { ";", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            this.records = new List<Record>();
            for (int i = 0; i < cells.Length; i++)
            {
                Record r = new Record();
                var temp = cells[i];
                r.Date = DateTime
                    .ParseExact(cells[i], "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                i++;
                r.Name = cells[i];
                i++;
                r.City = cells[i];
                i++;
                r.Code = cells[i];
                i++;
                r.Duration = int.Parse(cells[i]);
                i++;
                r.Tarif = int.Parse(cells[i]);
                i++;   
                r.Number = cells[i];
                records.Add(r);
            }
            filtered = records;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ApplyFilters();
            UpdateListViewData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            UpdateListViewData();
            UpdateTotal();
        }
    }
}
