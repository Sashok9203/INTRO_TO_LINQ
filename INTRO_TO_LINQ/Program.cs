namespace INTRO_TO_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integer = { 1, 2, -3, 345, 23, -12, 12, -45, 345, 7, 1, -33, 4, 0 };
            Show("Array", integer);

            Console.WriteLine("\n\"Task 1\"");
            Show("Positive by growth", integer.Where(n => n > 0).OrderBy(n => n));

            Console.WriteLine("\n\"Task 2\"");
            var twoDigit = integer.Where(n => n > 9 && n < 99);
            Console.WriteLine($" Two digit positive number count = {twoDigit.Count()}");
            Console.WriteLine($" Two digit positive number average = {twoDigit.Average()}");

            Console.WriteLine("\n\"Task 4\"");
            Console.WriteLine($" Max even value  = {integer.Where(n => n % 2 == 0).Max()}");

            Console.WriteLine("\n\"Task 3\"");
            int[] yars = { 1990, 2020, 2000, 1789, 2010, 2012, 2022 };
            Show("List of years", yars);
            Show("Leap years by descending", yars.Where(n => DateTime.IsLeapYear(n)).OrderByDescending(n => n));

           

            Console.WriteLine("\n\"Task 5\"");
            string[] strs = { "count", "max", "average", "where", "orderBy", "select" };
            Show("Strings", strs);
            Show("Strings !!!", strs.Select(n => $"{n}!!!"));

            Console.WriteLine("\n\"Task 6\"");
            Show("Strings", strs);
            char ch = 'a';
            Show("Strings with 'a'", strs.Where(n => n.Contains(ch)));

            Console.WriteLine("\n\"Task 7\"");
            var colection = strs.GroupBy(n => n.Length);
            foreach (var item in colection.OrderBy(n => n.Key))
            {
                Console.Write($" Group by {item.Key} : ");
                foreach (var str in item)
                    Console.Write($"{str} ");
                Console.WriteLine();
            }
        }

        public static void Show<T>(string title, IEnumerable<T> arr)
        {
            Console.Write($" {title} : ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
