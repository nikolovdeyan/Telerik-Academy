using System;

class JumpJump
{
    static void Main()
    {
        string instructions = Console.ReadLine();
        int pos = 0;

        while (true)
        {
            if (pos > instructions.Length - 1 || pos < 0)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", pos);
                break;
            }
            else if (instructions[pos] == '^')
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", pos);
                break;
            }
            else if (instructions[pos] == '0')
            {
                Console.WriteLine("Too drunk to go on after {0}!", pos);
                break;
            }
            else if ((Convert.ToInt32(instructions[pos]) % 2 == 0))
            {
                pos += (int)Char.GetNumericValue(instructions[pos]);
            }
            else if ((Convert.ToInt32(instructions[pos]) % 2 == 1))
            {
                pos -= (int)Char.GetNumericValue(instructions[pos]);
            }
        }
    }
}
