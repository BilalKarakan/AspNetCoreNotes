namespace PredicateDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = new Predicate<string>(FindName);
            var result = predicate.Invoke("Adam Bede");

            List<string> names = new() { "Adam Bede","Seth Bede","Hetty Sorrel","Dinah Morris"};
            var result2 = names.Find(predicate);
            var result3 = names.Find(FindName);

            var result4 = names.Find(a => a == "Adam Bede"); // There is no need for the predicate delegate and the FindName method.
        }

        private static bool FindName(string obj)
        {
            return obj == "Adam Bede";
        }
    }
}