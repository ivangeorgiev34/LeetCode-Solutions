namespace _0013.RomanToIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(RomanToInt(input!));
        }

        public static int RomanToInt(string s)
        {
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == 'I')
                {
                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'V' || s[i + 1] == 'X')
                        {
                            continue;
                        }
                    }

                    number += 1;
                }
                else if (s[i] == 'V')
                {
                    if (i > 0)
                    {
                        if (s[i - 1] == 'I')
                        {
                            number += 4;

                            continue;
                        }
                    }
                    number += 5;
                }
                else if (s[i] == 'X')
                {
                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'L' || s[i + 1] == 'C')
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (s[i - 1] == 'I')
                        {
                            number += 9;

                            continue;
                        }
                    }
                    number += 10;
                }
                else if (s[i] == 'L')
                {
                    if (i > 0)
                    {
                        if (s[i - 1] == 'X')
                        {
                            number += 40;

                            continue;
                        }
                    }
                    number += 50;
                }
                else if (s[i] == 'C')
                {

                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'D' || s[i + 1] == 'M')
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (s[i - 1] == 'X')
                        {
                            number += 90;

                            continue;
                        }
                    }
                    number += 100;
                }
                else if (s[i] == 'D')
                {
                    if (i > 0)
                    {
                        if (s[i - 1] == 'C')
                        {
                            number += 400;

                            continue;
                        }
                    }
                    number += 500;
                }
                else if (s[i] == 'M')
                {
                    if (i > 0)
                    {
                        if (s[i - 1] == 'C')
                        {
                            number += 900;

                            continue;
                        }
                    }
                    number += 1000;
                }
            }

            return number;
        }
    }
}
