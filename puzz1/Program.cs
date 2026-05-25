class Program
{

    static void Main(string[] args)
    {
        string[] steps = File.ReadAllLines("input.txt");
        int position = 50;
        int password = 0;
        
        // each step is L or R followed by digits
        foreach (string step in steps)
        {
            if (step.Length < 2)
            {
                continue;
            }
            char direction = step[0];
            bool atZero = position == 0;
            int movement = int.Parse(step[1..]);
            
            int passes = movement / 100;
            movement %= 100;

            if (direction == 'L')
            {
                movement *= -1;
            }
            position += movement;

            // wrap around because circle
            if (position < 0)
            {
                if (!atZero) { // don't double count if started at 0 going past end
                    passes++;
                }
                position += 100;
            } else if (position > 99)
            {
                if (!atZero) {
                    passes++;
                }
                position -= 100;
            } else if (position == 0)
            {
                password++;
            }
            password += passes;
        }
        Console.WriteLine(password);
    }
}
