using Microsoft.VisualBasic;

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
            PrzeliczWszystko();
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


        private void PrzeliczWszystko()
        {
            double sumaKcal = 0;
            double sumaBialko = 0;
            double sumaTluszcz = 0;
            double sumaWegle = 0;


            List<ListBox> lista = new List<ListBox> { breakfast, lunch, snack, dinner };

            foreach (ListBox l in lista)
            {
                foreach (Product p in l.Items)
                {
                    sumaKcal += p.Calories;
                    sumaBialko += p.Protein;
                    sumaTluszcz += p.Fat;
                    sumaWegle += p.Carbs;
                }

                lblkcal.Text = "Kalorie: " + sumaKcal + " kcal";
                lblprotein.Text = "Białko: " + sumaBialko + " g";
                lblfat.Text = "Tłuszcz: " + sumaTluszcz + " g";
                lblcarbs.Text = "Węglowodany: " + sumaWegle + " g";
            }
        }
    }

}
