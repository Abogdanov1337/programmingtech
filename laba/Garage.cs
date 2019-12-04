using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba
{
    class Garage<T> where T : class, ITransport
    {
        private T _car;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 80;

        public Garage(T car)
        {
            _car = car;
        }

        public static bool operator ==(Garage<T> g, T car)
        {
            if (g._car == null)
            {
                g._car = car;
            }
            if (g._car.getCarType() == car.getCarType())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Garage<T> g, T car)
        {
            if (g._car.getCarType() != car.getCarType())
            {
                g._car = car;
                return true;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 15, 15, 203, 103);
            Brush br = new SolidBrush(Color.Brown);
            g.FillRectangle(br, 15, 15, 200, 100);
        }
    }
}
