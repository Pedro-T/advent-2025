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
                long len = text.Length;
                for (int j = 1; j <= len / 2; j++)
                {
                    bool flag = true;
                    if (len % j != 0)
                    {
                        flag = false;
                        continue; // skip as the number length is not a multiple of j cleanly
                    }
                    string seq = text[0..j];
                    for (int k = j; k < len; k += j)
                    {
                        if (!text[k..(k+j)].Equals(seq))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        sum += i;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(sum);
    }
}