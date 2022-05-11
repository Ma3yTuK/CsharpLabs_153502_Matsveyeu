using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    public class Circle
    {
        public double radius;
        public double Radius 
        {
            get => radius;
            set
            {
                if (value > -1)
                    radius = value;
                else
                    radius = 0;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public Circle(double X, double Y, double Radius)
        {
            if (Radius < 0)
            {
                this.X = 0;
                this.Y = 0;
                this.Radius = 0;
                return;
            }
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        public static implicit operator Circle(double Radius)
        {
            return new Circle(0, 0, Radius);
        }
        public static explicit operator double(Circle obj)
        {
            return obj.Radius;
        }
        public double Square()
        {
            return Math.PI * Radius * Radius;
        }
        public double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return Square().ToString();
        }
        public double this[int index]
        {
            get
            {
                switch(index)
                {
                    case 1:
                        return X;
                    case 2:
                        return Y;
                    case 3:
                        return Radius;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 1:
                        X = value;
                        break;
                    case 2:
                        Y = value;
                        break;
                    case 3:
                        Radius = value;
                        break;
                    default:
                        break;
                }
            }
        }
        public static Circle operator ++(Circle obj)
        {
            obj.Radius++;
            return obj;
        }
        public static Circle operator --(Circle obj)
        {
            if (obj.Radius < 1)
                return obj;
            obj.Radius--;
            return obj;
        }
        public static Circle operator +(Circle obj1, Circle obj2)
        {
            return new Circle(obj1.X, obj1.Y, obj1.Radius+obj2.Radius);
        }
        public static Circle operator -(Circle obj1, Circle obj2)
        {
            if (obj1.Radius < obj2.Radius)
                return new Circle(0, 0, 0);
            return new Circle(obj1.X, obj1.Y, obj1.Radius - obj2.Radius);
        }
        public static Circle operator *(Circle obj1, Circle obj2)
        {
            return new Circle(obj1.X, obj1.Y, obj1.Radius * obj2.Radius);
        }
        public static Circle operator /(Circle obj1, Circle obj2)
        {
            if (obj2.Radius == 0)
                return new Circle(0, 0, 0);
            return new Circle(obj1.X, obj1.Y, obj1.Radius / obj2.Radius);
        }
        public static bool operator ==(Circle obj1, Circle obj2)
        {
            return obj1.Square() == obj2.Square();
        }
        public static bool operator !=(Circle obj1, Circle obj2)
        {
            return obj1.Square() != obj2.Square();
        }
        public static bool operator <(Circle obj1, Circle obj2)
        {
            return obj1.Square() < obj2.Square();
        }
        public static bool operator >(Circle obj1, Circle obj2)
        {
            return obj1.Square() > obj2.Square();
        }
        public static bool operator true(Circle obj)
        {
            if (obj.Radius == 0)
                return false;
            return true;
        }
        public static bool operator false(Circle obj)
        {
            if (obj.Radius == 0)
                return true;
            return false;
        }
    }
}
