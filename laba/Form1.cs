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
    public partial class Form1 : Form
    {
        private ITransport car;

        public Form1()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCar.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCarCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new SuperBenzovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Orange, Color.DarkBlue, Color.Black);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCar.Width, pictureBoxCar.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateGruzovik_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Gruzovick(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.DarkBlue, Color.Black);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCar.Width, pictureBoxCar.Height);
            Draw();
        }
    }
}
