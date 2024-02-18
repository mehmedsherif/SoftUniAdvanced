namespace _02.ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] airspace = new char[n, n];
            int jetfighterRow = -1;
            int jetfighterCol = -1;
            int enemyCount = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    airspace[row, col] = rowData[col];

                    if (rowData[col] == 'J')
                    {
                        jetfighterRow = row;
                        jetfighterCol = col;
                    }
                    else if (rowData[col] == 'E')
                    {
                        enemyCount++;
                    }
                }
            }

            int armor = 300;

            while (true)
            {
                string command = Console.ReadLine();

                int newJetfighterRow = jetfighterRow;
                int newJetfighterCol = jetfighterCol;

                if (command == "up")
                {
                    newJetfighterRow--;
                }
                else if (command == "down")
                {
                    newJetfighterRow++;
                }
                else if (command == "left")
                {
                    newJetfighterCol--;
                }
                else if (command == "right")
                {
                    newJetfighterCol++;
                }

                if (!IsInside(airspace, newJetfighterRow, newJetfighterCol))
                {
                    
                    break;
                }

                char newPosition = airspace[newJetfighterRow, newJetfighterCol];

                if (newPosition == '-')
                {
                    airspace[jetfighterRow, jetfighterCol] = '-';
                    airspace[newJetfighterRow, newJetfighterCol] = 'J';
                    jetfighterRow = newJetfighterRow;
                    jetfighterCol = newJetfighterCol;
                }
                else if (newPosition == 'R')
                {
                    armor = 300;
                    airspace[jetfighterRow, jetfighterCol] = '-';
                    airspace[newJetfighterRow, newJetfighterCol] = 'J';
                    jetfighterRow = newJetfighterRow;
                    jetfighterCol = newJetfighterCol;
                }
                else if (newPosition == 'E')
                {
                    armor -= 100;
                    airspace[jetfighterRow, jetfighterCol] = '-';
                    airspace[newJetfighterRow, newJetfighterCol] = 'J';
                    jetfighterRow = newJetfighterRow;
                    jetfighterCol = newJetfighterCol;

                    if (armor <= 0)
                    {
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterRow}, {jetfighterCol}]!");
                        break;
                    }

                    enemyCount--;

                    if (enemyCount == 0)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                }
            }

            PrintMatrix(airspace);
        }

        static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
