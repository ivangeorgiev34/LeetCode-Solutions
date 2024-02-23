namespace _0125.ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
        public static bool IsPalindrome(string s)
        {
            var isPalindrom = true;

            var leftPointer = 0;
            var rightPointer = s.Length - 1;


            int currentCharacterAsciiLeft;
            int currentCharacterAsciiRight;

            s = s.ToLower();

            while (leftPointer < rightPointer)
            {
                currentCharacterAsciiLeft = (int)s[leftPointer];
                currentCharacterAsciiRight = (int)s[rightPointer];

                while (IsAlphanumeric(currentCharacterAsciiLeft)
                && (leftPointer < rightPointer))
                {
                    leftPointer += 1;
                    currentCharacterAsciiLeft = (int)s[leftPointer];
                }

                while (IsAlphanumeric(currentCharacterAsciiRight)
                && (rightPointer > leftPointer))
                {
                    rightPointer -= 1;
                    currentCharacterAsciiRight = (int)s[rightPointer];
                }

                if (s[leftPointer] != s[rightPointer])
                {
                    isPalindrom = false;
                    break;
                }

                leftPointer += 1;
                rightPointer -= 1;
            }

            return isPalindrom;
        }

        public static bool IsAlphanumeric(int asciiNumber)
        {
            return ((asciiNumber >= 65 && asciiNumber <= 90)
                    || (asciiNumber >= 97 && asciiNumber <= 122)
                    || (asciiNumber >= 48 && asciiNumber <= 57)) == false;
        }
    }
}
