namespace ShapesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle("Cerc2");
            circle2.setCuloare("Rosu");
            circle2.setRaza(28);
            Circle.setCircleCode("ABC");
            circle1.writeToConsole();
            circle2.writeToConsole();
            Circle circle3 = new Circle("Cerc3", 36, "Alb");
            Circle circle4 = new Circle(circle2);
            Console.WriteLine(circle4.getCircleName());
            circle3.writeToConsole();
            Console.WriteLine(circle4.ariaCercului());
            Console.WriteLine(circle3.ariaCercului());

            ///Afiseaza perimetrul patratului format din raza cercului 2
            Console.WriteLine(MathUtilities.perimetruPatrat(Convert.ToInt32(circle2.getRaza())));

            ///Acelasi lucru ca mai sus, doar ca desfasurat
            double raza = circle2.getRaza();
            int razaInteger = Convert.ToInt32(raza);
            int perimetruPatrat = MathUtilities.perimetruPatrat(razaInteger);
            Console.WriteLine(perimetruPatrat);
        }
    }
}
