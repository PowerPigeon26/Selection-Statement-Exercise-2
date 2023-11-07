namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject? (ex. English, Math, etc)");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is my second favorite!");
                    break;
                case "English":
                    Console.WriteLine("Ugh, noooooooo...");
                    break;
                case "History":
                    Console.WriteLine("Oh, history is kinda fun to learn.");
                    break;
                case "Science":
                    Console.WriteLine("That's my favorite!");
                    break;
                case "Biology":
                    Console.WriteLine("Interesting, but difficult.");
                    break;
                default:
                    Console.WriteLine("That's a real nice subject. Yeah, um, nothin' beats that, um, subject.");
                    break;

            }
        }
    }
}