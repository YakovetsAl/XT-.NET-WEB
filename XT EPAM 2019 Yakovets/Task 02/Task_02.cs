using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Task_02
    {

        class Round
        {
            public double X = 1;
            public double Y = 1;
            public double R = 5;

            const double PI = 3.14159;

            public double GetСircumLenght()
            {
                return 2 * PI * R;
            }

            public double GetAreaCircle()
            {
                return PI * (R * R);
            }

        }

        class Triangle
        {
            public double A = 3;
            public double B = 7;
            public double C = 5;
            
            public double GetPerimeterTriangle()
            {
                return A + B + C;
            }

            public double GetAreaTriangle()
            {
                double p = GetPerimeterTriangle() / 2;
                return Math.Sqrt(p * ((p - A)*(p - B)*(p - C)));
            }

        }

        class User
        {
            public string Name = "Антон";
            public string Familiya = "Чехов";
            public string Patronymic = "Павлович";
            public string Birthday = "11.04.1894";
            public int Age = 56;
        }

        class Employee : User
        {
            public string Position = "Писатель";
            public int Skill = 3;
        }   

        static void Main(string[] args)
        {

            Round circle = new Round();
            Console.WriteLine("Длина окружности: " + circle.GetСircumLenght() + "\nПлощадь круга: " + circle.GetAreaCircle());

            Triangle triangle = new Triangle();
            Console.WriteLine("Площадь треугольника: " + triangle.GetAreaTriangle() + "\nПеримерт треугольника: " + triangle.GetPerimeterTriangle());

            User user = new User();
            Console.WriteLine(user.Name + " " + user.Familiya + " " + user.Patronymic + " ");

            Employee empl = new Employee();
            Console.WriteLine("Cотрудник:" + empl.Name + " " + empl.Familiya + " " + empl.Patronymic + " " + empl.Birthday + " " + empl.Age + " " + empl.Position  + " " + empl.Skill);

        }
    }
}
