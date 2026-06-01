using Microsoft.VisualBasic;
using System.Reflection;

namespace KalkulatorKCAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajProdukt(ListBox lista)
        {
            Product p = new Product();

            p.Name = Interaction.InputBox("Nazwa produktu:");
            p.Calories = Convert.ToDouble(Interaction.InputBox("Kcal:"));
            p.Protein = Convert.ToDouble(Interaction.InputBox("Białko:"));
            p.Fat = Convert.ToDouble(Interaction.InputBox("Tłuszcz:"));
            p.Carbs = Convert.ToDouble(Interaction.InputBox("Węglowodany:"));

            lista.Items.Add(p);
        }

        private void btnbreakfast_Click(object sender, EventArgs e)
        {
            DodajProdukt(breakfast);
        }

        private void btnlunch_Click(object sender, EventArgs e)
        {
            DodajProdukt(lunch);
        }

        private void btnsnack_Click(object sender, EventArgs e)
        {
            DodajProdukt(snack);
        }

        private void btndinner_Click(object sender, EventArgs e)
        {
            DodajProdukt(dinner);
        }
    }
}

