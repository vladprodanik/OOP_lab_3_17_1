using System;

namespace OOP_lab_3_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int round = 0;
            int square = 0;

            for (int i = 1; i < s.Length; ++i)
            {
                switch (s[i])
                {
                    case '(':
                        ++round;
                        break;

                    case ')':
                        --round;
                        break;

                    case '[':
                        ++square;
                        break;

                    case ']':
                        --square;
                        break;
                }
            }

            for (int i = 1; i < s.Length; ++i)
            {
                if ((s[i] == '(') && (s[i + 1] != ')'))
                {
                    s = s.Remove(i + 1, 1);
                    --i;
                }
            }

            Console.WriteLine(s);

            if ((round == 0) && (square == 0))
            {
                Console.WriteLine("Кiлькiсть вiдкритих та закритих дужок спiвпадає.");
            }
            else
            {
                Console.WriteLine("Кiлькiсть вiдкритих та закритих дужок не спiвпадає.");
            }
        }
    }
}