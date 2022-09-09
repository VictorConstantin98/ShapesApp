using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    internal class Circle
    {
        public enum Material {Wood,Iron};

        private static string circleCode;

        private readonly string circleName;
        private double raza;
        private string culoare;

        private Material circleMaterial;



        ///Constructor implicit
        public Circle()
        {
            this.culoare = "Rosu";
            this.circleMaterial = Material.Iron;
        }

        ///Constructor explicit partial
        public Circle(string circleName)
        {
            this.circleName = circleName;
        }

        ///Constructor explicit
        public Circle(string circleName, double raza, string culoare, Material material)
        {
            this.circleMaterial = material;
            this.circleName = circleName;
            this.raza = raza;
            this.culoare = culoare;
        }

        ///Copy constructor
        public Circle(Circle circle)
        {
            this.circleName = circle.circleName;
            this.raza = circle.raza;
            this.culoare = circle.culoare;
        }

        ///Getter material
        public Material getCircleMaterial()
        {
            return this.circleMaterial;
        }

        /*public void setRaza(double raza)
        {
            if(this.raza > 10 && this.circleMaterial == Material.Iron)
            {
                this.raza = raza;
            }
            else
            {
                if(this.raza < 10 && this.circleMaterial == Material.Wood)
                {
                    this.raza = raza;
                }
            }
            else
            {
                Console.Error.WriteLine("Nu se respecta conditia de raza si material.")
            }
        }*/

        ///Accesori raza
        public double getRaza()
        {
            return this.raza;
        }
        public void setRaza(double raza)
        {
            if (isRazaPositive(raza))
            {
                this.raza = raza;
                Console.WriteLine("Raza este pozitiva.");
            }
            else
            {
                Console.Error.WriteLine("Raza nu este pozitiva.");
            }
        }

        /// Accesori culoare
        public string getCuloare()
        {
            return this.culoare;
        }
        public void setCuloare(string culoare)
        {
            this.culoare = culoare;
        }

        ///Accesori nume(circleName)
        public string getCircleName()
        {
            return this.circleName;
        }
        
        ///Accesori circleCode
        public string getCircleCode()
        {
            return Circle.circleCode;
        }
        public static void setCircleCode(string circleCode)
        {
            if(circleCode.Length == 3)
            {
                Circle.circleCode = circleCode;
            }
            else
            {
                Console.Error.WriteLine("Nu are 3 litere.");
            }
        }

        ///Metoda de afisare
        public void writeToConsole()
        {
            Console.WriteLine("Nume: " + circleName + " + " + Circle.circleCode);
            Console.WriteLine("Raza: " + raza);
            Console.WriteLine("Culoare: " + culoare);
        }

        ///Metoda aria cercului
        public double ariaCercului()
        {
            double aria;
            aria = MathUtilities.PI * (this.raza * this.raza);
            return aria;
        }
        
        
        














































































        private static bool validareCircleCode(string circleCode)
        {
            if(circleCode.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isRazaPositive(double raza)
        {
            if (raza > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}