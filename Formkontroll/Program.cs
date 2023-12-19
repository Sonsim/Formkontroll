namespace Formkontroll
{
    internal class Program
    {

        public static List<Shape> list = new List<Shape>();
        static void Main()
        {
            var sirkel1 = new Circle(10, "Sirkel1", "Blå");
            var sirkel2 = new Circle(5, "Sirkel2", "Rød");

            var rektangel1 = new Rectangle(15,10,"Rektangel1", "blå");
            var rektagnel2 = new Rectangle(10,5, "Rektangel2", "grønn");

            var triangel1 = new Triangle("Triangel1", "blå", 5, 10);
            var triangel2 = new Triangle("Triangel2", "grønn", 10, 15);

            list.Add(sirkel1);
            list.Add(sirkel2);
            list.Add(rektangel1);
            list.Add(rektagnel2);
            list.Add(triangel2);
            list.Add(triangel1);

            PrintInfo();
            Console.ReadKey();
            TotaltAreal();
            Console.ReadKey();
            SortByAreal();
            Console.ReadKey();
            SortByColor();
            Console.ReadKey();



        }

        public static void PrintInfo()
        {
            foreach (var shape in list)
            {
                shape.BeregnAreal();
                Console.WriteLine($"Navn: {shape.Name}");
                Console.WriteLine($"Farge: {shape.Color}");
                Console.WriteLine($"Areal: {shape.Areal}");
                Console.WriteLine();

            }
        }

        public static void TotaltAreal()
        {
            double arealtotal = 0;

            for (int i = 0; i < list.Count; i++)
            {
                arealtotal = list[i].Areal + arealtotal;
            }

            Console.WriteLine($"Totalt areal: {arealtotal}");
            Console.WriteLine();
        }

        public static void SortByAreal()
        {
            var sortedbyAreal = list.OrderBy(x => x.Areal).ToList();
            foreach (var shape in sortedbyAreal)
            {
                Console.WriteLine($"Navn: {shape.Name}");
                Console.WriteLine($"Areal: {shape.Areal}");
            }

            Console.WriteLine();
        }

        public static void SortByColor()
        {
            Console.WriteLine("Hvilken farge vil du filtrere etter?");
            var ans = Console.ReadLine();

            switch (ans.ToLower())
            {
                case "blå":
                    foreach (var shape in list)
                    {
                        if (shape.Color.ToLower() == "blå")
                        {
                            Console.WriteLine($"Navn: {shape.Name}");
                            Console.WriteLine($"Farge: {shape.Color}");
                        }
                    }

                    break;
                case "rød":
                    foreach (var shape in list)
                    {
                        if (shape.Color.ToLower() == "rød")
                        {
                            Console.WriteLine($"Navn: {shape.Name}");
                            Console.WriteLine($"Farge: {shape.Color}");
                        }
                    }
                    break;
                case "grønn":
                    foreach (var shape in list)
                    {
                        if (shape.Color.ToLower() == "grønn")
                        {
                            Console.WriteLine($"Navn: {shape.Name}");
                            Console.WriteLine($"Farge: {shape.Color}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Feil kommando");
                    SortByColor();
                    break;
            }
        }
    }
}