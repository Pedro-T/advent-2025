class Program
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("input.txt");
        int sum = 0;
        foreach (string line in lines)
        {
            char p1 = line[0];
            int iMin = 1;
            for (int i = 1; i < line.Length -1; i++)
            {
                if (line[i] > p1)
                {
                    p1 = line[i];
                    iMin = i +1;
                }
            }
            char p2 = line[iMin];
            for (int i = iMin; i < line.Length; i++)
            {
                if (line[i] > p2)
                {
                    p2 = line[i];
                }
            }
            sum += int.Parse([p1,p2]);
        }
        Console.WriteLine(sum);
    }
}