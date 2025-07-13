namespace _0036.ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            Console.WriteLine(IsValidSudoku(board));
        }

        public static bool IsValidSudoku(char[][] board)
        {
            var rows = new HashSet<int>[9];
            var cols = new HashSet<int>[9];
            var grids = new HashSet<int>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<int>();
                cols[i] = new HashSet<int>();
                grids[i] = new HashSet<int>();
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board.Length; col++)
                {
                    if (board[row][col] == '.') continue;

                    var num = int.Parse(board[row][col].ToString());

                    if (rows[row].Contains(num)
                        || cols[col].Contains(num)
                        || grids[((row / 3) * 3) + (col / 3)].Contains(board[row][col])) return false;

                    rows[row].Add(num);
                    cols[col].Add(num);
                    grids[((row / 3) * 3) + (col / 3)].Add(board[row][col]);
                }
            }

            return true;
        }
    }
}
