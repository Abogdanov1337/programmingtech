using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public class SuperBenzovoz : Gruzovick, IComparable<SuperBenzovoz>, IEquatable<SuperBenzovoz>
    {
        public SuperBenzovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, Color wheelsColor) : 
            base(maxSpeed, weight, mainColor, dopColor, wheelsColor)
        {
        }

        public SuperBenzovoz(string info) : base(info)
{
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override string getCarType()
        {
            return "Бензовоз";
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
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(SuperBenzovoz other)
        {
            var res = (this is Gruzovick).CompareTo(other is Gruzovick);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(SuperBenzovoz other)
        {
            var res = (this as Gruzovick).Equals(other as Gruzovick);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SuperBenzovoz carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
