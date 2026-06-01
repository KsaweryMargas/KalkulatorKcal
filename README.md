# KalkulatorKCAL



Product.cs
---------------------------------------------------------------------------------------------------------------------
using System;

namespace KalkulatorKCAL
{
    public class Product
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }

        public override string ToString()
        {
            return $"{Name} | {Calories} kcal | B:{Protein} T:{Fat} W:{Carbs}";
        }
    }
}



Form1.cs
---------------------------------------------------------------------------------------------------------------------
using KalkulatorKCAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KalkulatorKCAL
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCalories.Text, out double kcal) ||
                !double.TryParse(txtProtein.Text, out double protein) ||
                !double.TryParse(txtFat.Text, out double fat) ||
                !double.TryParse(txtCarbs.Text, out double carbs))
            {
                MessageBox.Show("Wpisz poprawne liczby!");
                return;
            }

            Product p = new Product
            {
                Name = txtName.Text,
                Calories = kcal,
                Protein = protein,
                Fat = fat,
                Carbs = carbs
            };

            products.Add(p);
            listBox1.Items.Add(p);

            UpdateSummary();

        }

        private void UpdateSummary()
        {
            double kcal = 0;
            double protein = 0;
            double fat = 0;
            double carbs = 0;

            foreach (var p in products)
            {
                kcal += p.Calories;
                protein += p.Protein;
                fat += p.Fat;
                carbs += p.Carbs;
            }

            lblSummary.Text = $"Razem: {kcal} kcal | B:{protein} T:{fat} W:{carbs}";
        }
    }
}

<img width="558" height="307" alt="image" src="https://github.com/user-attachments/assets/58516d1b-ea2b-4f17-ae58-cf3c31a3f798" />
