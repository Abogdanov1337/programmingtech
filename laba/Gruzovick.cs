using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba
{
    public class Gruzovick : Vehicle
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;

        public Color DopColor { private set; get; }
        public Color WheelsColor { private set; get; }

        public Gruzovick(int maxSpeed, float weight, Color mainColor, Color dopColor, Color wheelsColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            WheelsColor = wheelsColor;
        }

        public override string getCarType() {
            return "Грузовик";
        }

        /// Определение движения транспорта

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// Отрисовка автомобиля

        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //границы автомобиля
            g.DrawEllipse(pen, _startPosX, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX + 2, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX + 62, _startPosY + 30, 20, 20);
            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 60, _startPosY, 20, 40);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 50, 41);

            //бочка
            Brush br = new SolidBrush(MainColor);
            g.FillEllipse(br, _startPosX, _startPosY, 20, 20);

            //колеса
            Brush brWheels = new SolidBrush(WheelsColor);
            g.FillEllipse(brWheels, _startPosX + 5, _startPosY + 30, 20, 20);
            g.FillEllipse(brWheels, _startPosX + 65, _startPosY + 30, 20, 20);

            //кузов            
            Brush brDop = new SolidBrush(DopColor);
            g.FillRectangle(br, _startPosX, _startPosY + 10, 10, 30);
            g.FillRectangle(br, _startPosX + 10, _startPosY, 50, 40);

            //стекла и кабина
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillEllipse(brBlue, _startPosX + 70, _startPosY, 20, 20);

            g.FillRectangle(brDop, _startPosX + 75, _startPosY + 13, 15, 27);
            g.FillRectangle(brDop, _startPosX + 60, _startPosY, 15, 40);


            //фара и ручка
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brWheels, _startPosX + 60, _startPosY + 20, 4, 6);
            g.FillEllipse(brYellow, _startPosX + 85, _startPosY + 28, 6, 4);
        }
    }
}
