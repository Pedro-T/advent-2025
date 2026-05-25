class Program
{
    static void Main(string[] args)
    {
        long sum = 0;

        string input = File.ReadAllLines("input.txt")[0];
        string[] inputs = input.Split(",");
        foreach (string rangeString in inputs)
        {
            string[] bits = rangeString.Split("-");
            long start = long.Parse(bits[0]);
            long end = long.Parse(bits[1]);

            for (long i = start; i <= end; i++)
            {
                string text = i.ToString();
                if (text.Length % 2 != 0)
                {
                    continue;
                }

                if (text[..(text.Length/2)].Equals(text[(text.Length/2)..]))
                {
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);


    }
}