using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class FormGarage : Form
    {
        Garage<ITransport> garage;

        private ITransport car;

        public FormGarage()
        {
            InitializeComponent();
            garage = new Garage<ITransport>(new Gruzovick(100, 1000, Color.Gray, Color.DarkBlue, Color.Black));
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Graphics gr = Graphics.FromImage(bmp);
            garage.Draw(gr);
            pictureBoxGarage.Image = bmp;
        }

        private void buttonParkAuto_Click(object sender, EventArgs e)
        {
            if (car != null)
            {
                if (garage == car)
                {
                    MessageBox.Show("Правильно");
                    Draw();
                }
                if (garage != car)
                {
                    MessageBox.Show("Неправильно");
                    Draw();
                }
            }
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
            Graphics gr = Graphics.FromImage(bmp);

            if (comboBoxCars.SelectedIndex == 0)
            {
                var gruzovik = new Gruzovick(100, 1000, Color.Gray, Color.DarkBlue, Color.Black);
                car = gruzovik;
                gruzovik.SetPosition(5, 5, pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                gruzovik.DrawCar(gr);
                pictureBoxTakeCar.Image = bmp;
            }

            if (comboBoxCars.SelectedIndex == 1)
            {
                var benzovoz = new SuperBenzovoz(100, 1000, Color.Orange, Color.DarkBlue, Color.Black);
                car = benzovoz;
                benzovoz.SetPosition(5, 5, pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                benzovoz.DrawCar(gr);
                pictureBoxTakeCar.Image = bmp;
            }
            Draw();
        }
    }
}
