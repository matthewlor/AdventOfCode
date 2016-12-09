using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(dayOnePartOne());
            //Console.WriteLine(dayOnePartTwo());

            //Console.WriteLine(dayTwoPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day2Test.txt"));
            //Console.WriteLine(dayTwoPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day2.txt"));

            //Console.WriteLine(dayTwoPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day2Test.txt"));
            //Console.WriteLine(dayTwoPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day2.txt"));

            //Console.WriteLine(dayThreePartOne(@"C:\Workspace\AdventOfCode\dayFiles\day3test.txt"));
            //Console.WriteLine(dayThreePartOne(@"C:\Workspace\AdventOfCode\dayFiles\day3.txt"));

            //Console.WriteLine(dayThreePartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day3test.txt"));
            //Console.WriteLine(dayThreePartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day3.txt"));

            //Console.WriteLine(dayFourPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day4test.txt"));
            //Console.WriteLine(dayFourPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day4.txt"));
            //Console.WriteLine(dayFourPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day4test.txt"));
            //Console.WriteLine(dayFourPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day4.txt"));

            //Console.WriteLine(daySevenPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day7test.txt"));
            //Console.WriteLine(daySevenPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day7.txt"));

            //Console.WriteLine(daySevenPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day7test.txt"));
            //Console.WriteLine(daySevenPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day7.txt"));


            //Console.WriteLine(dayEightPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day8test.txt"));
            //Console.WriteLine(dayEightPartOne(@"C:\Workspace\AdventOfCode\dayFiles\day8.txt"));
            //Console.WriteLine(dayEightPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day8test.txt"));
            //Console.WriteLine(dayEightPartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day8.txt"));

            //Console.WriteLine(dayNinePartOne(@"C:\Workspace\AdventOfCode\dayFiles\day9test.txt"));
            //Console.WriteLine(dayNinePartOne(@"C:\Workspace\AdventOfCode\dayFiles\day9.txt"));
            Console.WriteLine(dayNinePartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day9test.txt"));
            //Console.WriteLine(dayNinePartTwo(@"C:\Workspace\AdventOfCode\dayFiles\day9.txt"));

            string a = "(3x3)XYZ";

            string z = a.Substring(0,a.IndexOf('('));

            Console.Read();

        }

        #region Day 1
        public static int dayOnePartOne()
        {
            #region instructions array
            string[] instructions = {
                "R4",
                "R1",
                "L2",
                "R1",
                "L1",
                "L1",
                "R1",
                "L5",
                "R1",
                "R5",
                "L2",
                "R3",
                "L3",
                "L4",
                "R4",
                "R4",
                "R3",
                "L5",
                "L1",
                "R5",
                "R3",
                "L4",
                "R1",
                "R5",
                "L1",
                "R3",
                "L2",
                "R3",
                "R1",
                "L4",
                "L1",
                "R1",
                "L1",
                "L5",
                "R1",
                "L2",
                "R2",
                "L3",
                "L5",
                "R1",
                "R5",
                "L1",
                "R188",
                "L3",
                "R2",
                "R52",
                "R5",
                "L3",
                "R79",
                "L1",
                "R5",
                "R186",
                "R2",
                "R1",
                "L3",
                "L5",
                "L2",
                "R2",
                "R4",
                "R5",
                "R5",
                "L5",
                "L4",
                "R5",
                "R3",
                "L4",
                "R4",
                "L4",
                "L4",
                "R5",
                "L4",
                "L3",
                "L1",
                "L4",
                "R1",
                "R2",
                "L5",
                "R3",
                "L4",
                "R3",
                "L3",
                "L5",
                "R1",
                "R1",
                "L3",
                "R2",
                "R1",
                "R2",
                "R2",
                "L4",
                "R5",
                "R1",
                "R3",
                "R2",
                "L2",
                "L2",
                "L1",
                "R2",
                "L1",
                "L3",
                "R5",
                "R1",
                "R4",
                "R5",
                "R2",
                "R2",
                "R4",
                "R4",
                "R1",
                "L3",
                "R4",
                "L2",
                "R2",
                "R1",
                "R3",
                "L5",
                "R5",
                "R2",
                "R5",
                "L1",
                "R2",
                "R4",
                "L1",
                "R5",
                "L3",
                "L3",
                "R1",
                "L4",
                "R2",
                "L2",
                "R1",
                "L1",
                "R4",
                "R3",
                "L2",
                "L3",
                "R3",
                "L2",
                "R1",
                "L4",
                "R5",
                "L1",
                "R5",
                "L2",
                "L1",
                "L5",
                "L2",
                "L5",
                "L2",
                "L4",
                "L2",
                "R3"
            };
            #endregion 

            int n = 0;
            int e = 0;
            int s = 0;
            int w = 0;

            char currentDirection = 'n';

            foreach (string instruction in instructions)
            {
                char turnDirection = instruction[0];
                int units = Int32.Parse(instruction.Substring(1, instruction.Length - 1));

                //SET DIRECTION
                switch (currentDirection)
                {
                    case 'n':
                        if (turnDirection == 'R')
                        {
                            e += units;
                            currentDirection = 'e';
                        }
                        else
                        {
                            w += units;
                            currentDirection = 'w';
                        }
                        break;
                    case 'e':
                        if (turnDirection == 'R')
                        {
                            s += units;
                            currentDirection = 's';
                        }
                        else
                        {
                            n += units;
                            currentDirection = 'n';
                        }
                        break;
                    case 's':
                        if (turnDirection == 'R')
                        {
                            w += units;
                            currentDirection = 'w';
                        }
                        else
                        {
                            e += units;
                            currentDirection = 'e';
                        }
                        break;
                    case 'w':
                        if (turnDirection == 'R')
                        {
                            n += units;
                            currentDirection = 'n';
                        }
                        else
                        {
                            s += units;
                            currentDirection = 's';
                        }
                        break;
                }

                if (n - s == 0)
                {

                }

                //Console.WriteLine(turnDirection + "" + units + " " + currentDirection);
                //Console.WriteLine((Math.Abs(n - s)) + (Math.Abs(e - w)));
                //Console.Read();

            }

            //Console.Read();
            return (Math.Abs(n - s)) + (Math.Abs(e - w));
        }

        public static int dayOnePartTwo()
        {
            #region instructions array
            string[] instructions = {
                "R4",
                "R1",
                "L2",
                "R1",
                "L1",
                "L1",
                "R1",
                "L5",
                "R1",
                "R5",
                "L2",
                "R3",
                "L3",
                "L4",
                "R4",
                "R4",
                "R3",
                "L5",
                "L1",
                "R5",
                "R3",
                "L4",
                "R1",
                "R5",
                "L1",
                "R3",
                "L2",
                "R3",
                "R1",
                "L4",
                "L1",
                "R1",
                "L1",
                "L5",
                "R1",
                "L2",
                "R2",
                "L3",
                "L5",
                "R1",
                "R5",
                "L1",
                "R188",
                "L3",
                "R2",
                "R52",
                "R5",
                "L3",
                "R79",
                "L1",
                "R5",
                "R186",
                "R2",
                "R1",
                "L3",
                "L5",
                "L2",
                "R2",
                "R4",
                "R5",
                "R5",
                "L5",
                "L4",
                "R5",
                "R3",
                "L4",
                "R4",
                "L4",
                "L4",
                "R5",
                "L4",
                "L3",
                "L1",
                "L4",
                "R1",
                "R2",
                "L5",
                "R3",
                "L4",
                "R3",
                "L3",
                "L5",
                "R1",
                "R1",
                "L3",
                "R2",
                "R1",
                "R2",
                "R2",
                "L4",
                "R5",
                "R1",
                "R3",
                "R2",
                "L2",
                "L2",
                "L1",
                "R2",
                "L1",
                "L3",
                "R5",
                "R1",
                "R4",
                "R5",
                "R2",
                "R2",
                "R4",
                "R4",
                "R1",
                "L3",
                "R4",
                "L2",
                "R2",
                "R1",
                "R3",
                "L5",
                "R5",
                "R2",
                "R5",
                "L1",
                "R2",
                "R4",
                "L1",
                "R5",
                "L3",
                "L3",
                "R1",
                "L4",
                "R2",
                "L2",
                "R1",
                "L1",
                "R4",
                "R3",
                "L2",
                "L3",
                "R3",
                "L2",
                "R1",
                "L4",
                "R5",
                "L1",
                "R5",
                "L2",
                "L1",
                "L5",
                "L2",
                "L5",
                "L2",
                "L4",
                "L2",
                "R3"

            };
            #endregion 

            string[] instructions2 = { "R8", "R4", "R4", "R8" };

            HashSet<Point> positions = new HashSet<Point>();
            int x = 0;
            int y = 0;

            char currentDirection = 'n';
            Point currentPoint = new Point(0, 0);

            positions.Add(currentPoint);

            foreach (string instruction in instructions)
            {
                char turnDirection = instruction[0];
                int units = Int32.Parse(instruction.Substring(1, instruction.Length - 1));

                currentDirection = setCurrentDirection(currentDirection, turnDirection);

                while (units > 0)
                {
                    switch (currentDirection)
                    {
                        case 'n':
                            y += 1;
                            break;
                        case 'e':
                            x += 1;
                            break;
                        case 's':
                            y -= 1;
                            break;
                        case 'w':
                            x -= 1;
                            break;
                    }

                    if (positions.Contains(new Point(x, y)))
                    {
                        return Math.Abs(x) + Math.Abs(y);
                    }
                    else
                    {
                        positions.Add(new Point(x, y));
                    }

                    units -= 1;
                }

            }

            return 0;
        }

        public static char setCurrentDirection(char currentDirection, char turnDirection)
        {
            switch (currentDirection)
            {
                case 'n':
                    if (turnDirection == 'R')
                    {
                        currentDirection = 'e';
                    }
                    else
                    {
                        currentDirection = 'w';
                    }
                    break;
                case 'e':
                    if (turnDirection == 'R')
                    {
                        currentDirection = 's';
                    }
                    else
                    {
                        currentDirection = 'n';
                    }
                    break;
                case 's':
                    if (turnDirection == 'R')
                    {
                        currentDirection = 'w';
                    }
                    else
                    {
                        currentDirection = 'e';
                    }
                    break;
                case 'w':
                    if (turnDirection == 'R')
                    {
                        currentDirection = 'n';
                    }
                    else
                    {
                        currentDirection = 's';
                    }
                    break;
            }

            return currentDirection;
        }
        #endregion

        #region Day 2
        public static string dayTwoPartOne(string file)
        {
            string[] dayTwoLines = System.IO.File.ReadAllLines(file);
            Point currentButton = new Point(0, 0);
            string code = "";

            int x = currentButton.X;
            int y = currentButton.Y;

            foreach (string line in dayTwoLines)
            {
                //Console.WriteLine(line);
                foreach (char direction in line)
                {
                    //Console.WriteLine(direction);
                    switch (direction)
                    {
                        case 'U':
                            y = (y == 1) ? 1 : y + 1;
                            break;
                        case 'D':
                            y = (y == -1) ? -1 : y - 1;
                            break;
                        case 'R':
                            x = (x == 1) ? 1 : x + 1;
                            break;
                        case 'L':
                            x = (x == -1) ? -1 : x - 1;
                            break;
                    }
                    currentButton.X = x;
                    currentButton.Y = y;
                }
                code += pointToKeyNum(new Point(x, y));
            }
            return code;
        }

        public static string dayTwoPartTwo(string file)
        {
            string[] dayTwoLines = System.IO.File.ReadAllLines(file);
            Point currentButton = new Point(-2, 0);
            int[] minMax = pointToKeyNum2(currentButton);
            string code = "";

            int x = currentButton.X;
            int y = currentButton.Y;

            foreach (string line in dayTwoLines)
            {
                //Console.WriteLine(line);
                foreach (char direction in line)
                {
                    //Console.WriteLine(direction);
                    switch (direction)
                    {
                        case 'U':
                            if (y < minMax[4])
                            {
                                y++;
                            }
                            //y = (y == 1) ? 1 : y + 1;
                            break;
                        case 'D':
                            if (y > minMax[3])
                            {
                                y--;
                            }
                            //y = (y == -1) ? -1 : y - 1;
                            break;
                        case 'R':
                            if (x < minMax[2])
                            {
                                x++;
                            }
                            //x = (x == 1) ? 1 : x + 1;
                            break;
                        case 'L':
                            if (x > minMax[1])
                            {
                                x--;
                            }
                            //x = (x == -1) ? -1 : x - 1;
                            break;
                    }
                    currentButton.X = x;
                    currentButton.Y = y;
                    minMax = pointToKeyNum2(currentButton);
                }

                char abcd = '0';
                if (pointToKeyNum2(new Point(x, y))[0] == 10)
                {
                    abcd = 'A';
                }
                if (pointToKeyNum2(new Point(x, y))[0] == 11)
                {
                    abcd = 'B';
                }
                if (pointToKeyNum2(new Point(x, y))[0] == 12)
                {
                    abcd = 'C';
                }
                if (pointToKeyNum2(new Point(x, y))[0] == 13)
                {
                    abcd = 'D';
                }

                if (abcd == '0')
                {
                    code += pointToKeyNum2(new Point(x, y))[0].ToString();
                }
                else
                {
                    code += abcd;
                }

            }
            return code;
        }

        public static char pointToKeyNum(Point button)
        {
            if (button.X == -1 && button.Y == 1)
            {
                return '1';
            }
            if (button.X == 0 && button.Y == 1)
            {
                return '2';
            }
            if (button.X == 1 && button.Y == 1)
            {
                return '3';
            }
            if (button.X == -1 && button.Y == 0)
            {
                return '4';
            }
            if (button.X == 0 && button.Y == 0)
            {
                return '5';
            }
            if (button.X == 1 && button.Y == 0)
            {
                return '6';
            }
            if (button.X == -1 && button.Y == -1)
            {
                return '7';
            }
            if (button.X == 0 && button.Y == -1)
            {
                return '8';
            }
            if (button.X == 1 && button.Y == -1)
            {
                return '9';
            }

            return '0';
        }

        //Key, Min X, Max X, Min Y, Max Y
        public static int[] pointToKeyNum2(Point button)
        {
            if (button.X == 0 && button.Y == 2)
            {
                return new int[] { 1, 0, 0, -2, 2 };
            }
            if (button.X == -1 && button.Y == 1)
            {
                return new int[] { 2, -1, 1, -1, 1 };
            }
            if (button.X == 0 && button.Y == 1)
            {
                return new int[] { 3, -1, 1, -2, 2 };
            }
            if (button.X == 1 && button.Y == 1)
            {
                return new int[] { 4, -1, 1, -1, 1 };
            }
            if (button.X == -2 && button.Y == 0)
            {
                return new int[] { 5, -2, 2, 0, 0 };
            }
            if (button.X == -1 && button.Y == 0)
            {
                return new int[] { 6, -2, 2, -1, 1 };
            }
            if (button.X == 0 && button.Y == 0)
            {
                return new int[] { 7, -2, 2, -2, 2 };
            }
            if (button.X == 1 && button.Y == 0)
            {
                return new int[] { 8, -2, 2, -1, 1 };
            }
            if (button.X == 2 && button.Y == 0)
            {
                return new int[] { 9, -2, 2, 0, 0 };
            }

            //A
            if (button.X == -1 && button.Y == -1)
            {
                return new int[] { 10, -1, 1, -1, 1 };
            }
            //B
            if (button.X == 0 && button.Y == -1)
            {
                return new int[] { 11, -1, 1, -2, 2 };
            }
            //C
            if (button.X == 1 && button.Y == -1)
            {
                return new int[] { 12, -1, 1, -1, 1 };
            }
            //D
            if (button.X == 0 && button.Y == -2)
            {
                return new int[] { 13, 0, 0, -2, 2 };
            }

            return new int[] { 0, 0, 0, 0, 0 }; ;
        }

        #endregion

        #region Day 3
        public static int dayThreePartOne(string file)
        {
            int triangles = 0;
            string[] dayThreeLines = System.IO.File.ReadAllLines(file);

            foreach (string line in dayThreeLines)
            {
                string[] stringSides = line.Split(' ');
                int[] sides = Array.ConvertAll<string, int>(stringSides, int.Parse);

                Array.Sort(sides);

                if ((sides[0] + sides[1]) > sides[2])
                {
                    triangles++;
                }

            }

            return triangles;
        }

        public static int dayThreePartTwo(string file)
        {
            int triangles = 0;
            string[] dayThreeLines = System.IO.File.ReadAllLines(file);
            int count = 0;

            int[] triangle1 = new int[3];
            int[] triangle2 = new int[3];
            int[] triangle3 = new int[3];

            foreach (string line in dayThreeLines)
            {
                string[] oneStringSide = line.Split(' ');
                int[] oneIntSide = Array.ConvertAll<string, int>(oneStringSide, int.Parse);

                triangle1[count] = oneIntSide[0];
                triangle2[count] = oneIntSide[1];
                triangle3[count] = oneIntSide[2];

                if ((count + 1) % 3 == 0)
                {
                    Array.Sort(triangle1);
                    Array.Sort(triangle2);
                    Array.Sort(triangle3);

                    triangles += isTriangle(triangle1);
                    triangles += isTriangle(triangle2);
                    triangles += isTriangle(triangle3);

                    count = 0;
                }
                else
                {
                    count++;
                }


            }

            return triangles;
        }

        public static int isTriangle(int[] testMe)
        {
            if ((testMe[0] + testMe[1]) > testMe[2])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Day 4
        public static int dayFourPartOne(string file)
        {
            int realSectorSum = 0;
            string[] dayFourLines = System.IO.File.ReadAllLines(file);
            //KeyValuePair<string, int> letterCounts = new KeyValuePair<string, int>();


            //letterCounts["test"] = (letterCounts.ContainsKey("test")) ? 1 : 0;

            foreach (string line in dayFourLines)
            {
                Dictionary<string, int> letterCounts = new Dictionary<string, int>();
                List<char> id = new List<char>();
                string checksum = "";
                Dictionary<string, int> top5 = new Dictionary<string, int>();

                for (int i = 0; i < line.Length; i++)
                {
                    ///If lowercase letter
                    if (line[i] >= 97 && line[i] <= 122)
                    {
                        if (letterCounts.ContainsKey(line[i].ToString()))
                        {
                            letterCounts[line[i].ToString()]++;
                        }
                        else
                        {
                            letterCounts[line[i].ToString()] = 1;
                        }
                    }
                    if (line[i] >= 48 && line[i] <= 57)
                    {
                        id.Add(line[i]);
                    }
                    if (line[i] == 91)
                    {
                        checksum = line.Substring(i + 1, line.Length - i - 2);
                        break;
                    }
                }

                top5 = letterCounts.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).Take(5).ToDictionary(pair => pair.Key, pair => pair.Value);

                string top5str = string.Join("", top5.Select(pair => pair.Key).ToArray());

                if (top5str.Equals(checksum))
                {
                    realSectorSum += Int32.Parse(string.Join("", id.ToArray()));
                }
            }

            return realSectorSum;
        }

        public static int dayFourPartTwo(string file)
        {
            int realSectorSum = 0;
            string encryptedName = "";
            Dictionary<string, int> decryptedNames = new Dictionary<string, int>();
            string[] dayFourLines = System.IO.File.ReadAllLines(file);
            //KeyValuePair<string, int> letterCounts = new KeyValuePair<string, int>();


            //letterCounts["test"] = (letterCounts.ContainsKey("test")) ? 1 : 0;

            foreach (string line in dayFourLines)
            {
                Dictionary<string, int> letterCounts = new Dictionary<string, int>();
                List<char> id = new List<char>();
                string checksum = "";
                Dictionary<string, int> top5 = new Dictionary<string, int>();

                for (int i = 0; i < line.Length; i++)
                {
                    ///If lowercase letter
                    if (line[i] >= 97 && line[i] <= 122)
                    {
                        if (letterCounts.ContainsKey(line[i].ToString()))
                        {
                            letterCounts[line[i].ToString()]++;
                        }
                        else
                        {
                            letterCounts[line[i].ToString()] = 1;
                        }
                    }
                    if (line[i] >= 48 && line[i] <= 57)
                    {
                        id.Add(line[i]);
                    }
                    if (line[i] == 91)
                    {
                        checksum = line.Substring(i + 1, line.Length - i - 2);
                        break;
                    }
                }

                top5 = letterCounts.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).Take(5).ToDictionary(pair => pair.Key, pair => pair.Value);

                string top5str = string.Join("", top5.Select(pair => pair.Key).ToArray());

                //Legit room decrypt it!!
                if (top5str.Equals(checksum))
                {
                    realSectorSum += Int32.Parse(string.Join("", id.ToArray()));

                    encryptedName = line.Split('[')[0];

                    KeyValuePair<string, int> d = decryptName(encryptedName);

                    Console.WriteLine(d.Key + " " + d.Value);

                }
            }

            return realSectorSum;
        }

        public static KeyValuePair<string, int> decryptName(string encryptedName)
        {
            //encryptedName = @"qzmt-zixmtkozy-ivhz-343";

            List<char> decryptedName = new List<char>();
            string[] encryptedNameArray = encryptedName.Split('-');
            int id = Int32.Parse(encryptedNameArray[encryptedNameArray.Length - 1]);
            int shiftChipher = id % 26;

            for (int i = 0; i < encryptedNameArray.Length - 1; i++)
            {
                //a 97 to z 122 --minus 96
                foreach (char letter in encryptedNameArray[i])
                {

                    if (letter + shiftChipher > 122)
                    {
                        decryptedName.Add((char)(96 + ((letter + shiftChipher) - 122)));
                    }
                    else
                    {
                        decryptedName.Add((char)(letter + shiftChipher));
                    }
                }

                decryptedName.Add(' ');
            }

            return new KeyValuePair<string, int>(string.Join("", decryptedName.ToArray()), id);
        }

        #endregion

        #region Day 5

        #endregion

        #region Day 7
        public static int daySevenPartOne(string file)
        {
            string[] daySevenLines = System.IO.File.ReadAllLines(file);
            int TLScount = 0;

            foreach (string line in daySevenLines)
            {
                List<string> nonBracketStrings = new List<string>();
                List<string> bracketStrings = new List<string>();
                string removingLine = line;

                while (removingLine.Length > 0)
                {
                    if (removingLine.Contains("["))
                    {
                        nonBracketStrings.Add(removingLine.Substring(0, removingLine.IndexOf("[")));
                        bracketStrings.Add(removingLine.Substring(removingLine.IndexOf("[") + 1, removingLine.IndexOf("]") - removingLine.IndexOf("[") - 1));
                        removingLine = removingLine.Remove(0, removingLine.IndexOf("]") + 1);
                    }
                    else
                    {
                        nonBracketStrings.Add(removingLine);
                        removingLine = removingLine.Remove(0, removingLine.Length);
                    }

                }

                bool checkNonBrackets = true;
                foreach (string bracketString in bracketStrings)
                {
                    if (hasPalindrome(bracketString))
                    {
                        checkNonBrackets = false;
                        break;
                    }
                }

                if (checkNonBrackets)
                {
                    foreach (string nonBracketString in nonBracketStrings)
                    {
                        if (hasPalindrome(nonBracketString))
                        {
                            TLScount++;
                            break;
                        }
                    }
                }
            }

            return TLScount;
        }

        public static int daySevenPartTwo(string file)
        {
            string[] daySevenLines = System.IO.File.ReadAllLines(file);
            int SSLcount = 0;

            foreach (string line in daySevenLines)
            {
                List<string> nonBracketStrings = new List<string>();
                List<string> bracketStrings = new List<string>();
                List<string> abaStrings = new List<string>();

                string removingLine = line;

                while (removingLine.Length > 0)
                {
                    if (removingLine.Contains("["))
                    {
                        nonBracketStrings.Add(removingLine.Substring(0, removingLine.IndexOf("[")));
                        bracketStrings.Add(removingLine.Substring(removingLine.IndexOf("[") + 1, removingLine.IndexOf("]") - removingLine.IndexOf("[") - 1));
                        removingLine = removingLine.Remove(0, removingLine.IndexOf("]") + 1);
                    }
                    else
                    {
                        nonBracketStrings.Add(removingLine);
                        removingLine = removingLine.Remove(0, removingLine.Length);
                    }

                }

                foreach (string nonBracketString in nonBracketStrings)
                {
                    getABAs(nonBracketString, ref abaStrings);
                }

                foreach (string bracketString in bracketStrings)
                {
                    if (checkBABs(bracketString, ref abaStrings))
                    {
                        SSLcount++;
                    }
                }
            }

            return SSLcount;
        }

        public static bool hasPalindrome(string s)
        {
            bool containsPalidrome = false;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i + 4 <= s.Length)
                {
                    string z = s.Substring(i, 4);

                    if (s[i] != s[i + 1])
                    {
                        if (s[i] == s[i + 3] && s[i + 1] == s[i + 2])
                        {
                            containsPalidrome = true;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return containsPalidrome;
        }

        public static void getABAs(string s, ref List<string> abas)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i + 3 <= s.Length)
                {
                    string z = s.Substring(i, 3);

                    if (s[i] == s[i + 2] && s[i] != s[i + 1])
                    {
                        abas.Add(z);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static bool checkBABs(string bracketString, ref List<string> abas)
        {
            foreach (string aba in abas)
            {
                string bab = aba[1].ToString() + aba[0].ToString() + aba[1].ToString();

                if (bracketString.Contains(bab))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Day 8
        public static int dayEightPartOne(string file)
        {
            string[] dayEightLines = System.IO.File.ReadAllLines(file);

            char[,] canvas = new char[6, 50];
            //char[,] canvas = new char[3, 7];

            int lightCount = 0;

            //FILL WITH -
            for (int y = 0; y < canvas.GetLength(0); y++)
            {
                for (int x = 0; x < canvas.GetLength(1); x++)
                {
                    canvas[y, x] = '-';
                    //Console.WriteLine(canvas[y, x]);// = '#';
                }
            }

            foreach (string line in dayEightLines)
            {
                //DRAW DEBUG
                for (int y = 0; y < canvas.GetLength(0); y++)
                {
                    for (int x = 0; x < canvas.GetLength(1); x++)
                    {
                        Console.Write(canvas[y, x]);// = '#';
                        if (canvas[y, x] == '#')
                        {
                            //lightCount++;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();

                string tempLine = line;

                string command = line.Substring(0, line.IndexOf(" "));

                switch (command)
                {
                    case "rect":

                        int width = Int32.Parse(line.Substring(line.IndexOf(" ") + 1, line.IndexOf("x") - (line.IndexOf(" ") + 1)));
                        int height = Int32.Parse(line.Substring(line.IndexOf("x") + 1, line.Length - (line.IndexOf("x") + 1)));

                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                canvas[y, x] = '#';
                            }
                        }

                        break;
                    case "rotate":
                        string[] values = line.Substring(line.IndexOf('=') + 1, line.Length - line.IndexOf('=') - 1).Split(' ');
                        int rotateIndex = int.Parse(values[0]);
                        int rotateValue = int.Parse(values[2]);

                        if (line.Contains("x="))
                        {
                            List<Point> hashPoints = new List<Point>();

                            //Get all the points and clear row/cloumn with '-'
                            for (int y = 0; y < canvas.GetLength(0); y++)
                            {
                                if (canvas[y, rotateIndex] == '#')
                                {
                                    hashPoints.Add(new Point(rotateIndex, y));
                                    canvas[y, rotateIndex] = '-';
                                }

                            }

                            //Update points co-ordinates
                            for (int i = 0; i < hashPoints.Count; i++)
                            {
                                if (hashPoints[i].Y + rotateValue > canvas.GetLength(0) - 1)
                                {
                                    int overflow = (hashPoints[i].Y + rotateValue) - (canvas.GetLength(0));
                                    hashPoints[i] = new Point(rotateIndex, overflow);
                                }
                                else
                                {
                                    hashPoints[i] = new Point(rotateIndex, hashPoints[i].Y + rotateValue);
                                }
                            }

                            //insert back into 2d array
                            foreach (Point point in hashPoints)
                            {
                                canvas[point.Y, point.X] = '#';
                            }

                        }
                        else
                        {
                            List<Point> hashPoints = new List<Point>();

                            //Get all the points and clear row/cloumn with '-'
                            for (int x = 0; x < canvas.GetLength(1); x++)
                            {
                                if (canvas[rotateIndex, x] == '#')
                                {
                                    hashPoints.Add(new Point(x, rotateIndex));
                                    canvas[rotateIndex, x] = '-';
                                }

                            }

                            //Update points co-ordinates
                            for (int i = 0; i < hashPoints.Count; i++)
                            {
                                if (hashPoints[i].X + rotateValue > canvas.GetLength(1) - 1)
                                {
                                    int overflow = (hashPoints[i].X + rotateValue) - (canvas.GetLength(1));
                                    hashPoints[i] = new Point(overflow, rotateIndex);
                                }
                                else
                                {
                                    hashPoints[i] = new Point(hashPoints[i].X + rotateValue, rotateIndex);
                                }
                            }

                            //insert back into 2d array
                            foreach (Point point in hashPoints)
                            {
                                canvas[point.Y, point.X] = '#';
                            }
                        }
                        break;
                }

            }


            //DRAW
            for (int y = 0; y < canvas.GetLength(0); y++)
            {
                for (int x = 0; x < canvas.GetLength(1); x++)
                {
                    Console.Write(canvas[y, x]);// = '#';
                    if (canvas[y, x] == '#')
                    {
                        lightCount++;
                    }
                }
                Console.WriteLine();
            }

            return lightCount;
        }
        #endregion

        #region Day 9
        public static int dayNinePartOne(string file)
        {
            string[] dayNineLines = System.IO.File.ReadAllLines(file);

            string decompressedStr = "";

            foreach (string line in dayNineLines)
            {
                string tempLine = line;

                while (tempLine.Length > 0)
                {
                    //end case where there is no '(' left
                    if (!tempLine.Contains('('))
                    {
                        decompressedStr += tempLine;
                        break;
                    }

                    //Check if any strings before the '(' ) and remove decompressed part
                    if (tempLine.Substring(0, tempLine.IndexOf('(')).Length > 0)
                    {
                        decompressedStr += tempLine.Substring(0, tempLine.IndexOf('('));
                        tempLine = tempLine.Remove(0, tempLine.IndexOf('('));
                    }
                    //We are at a '(' its time to decompress and then remove decompressed part
                    else
                    {
                        //get marker data
                        int spaces = int.Parse(tempLine.Substring(1, tempLine.IndexOf('x') - 1));
                        int multiply = int.Parse(tempLine.Substring(tempLine.IndexOf('x') + 1, (tempLine.IndexOf(')') - 1) - (tempLine.IndexOf('x'))));

                        //remove marker ex: (3x3)afdsa => afdsa
                        tempLine = tempLine.Remove(0, tempLine.IndexOf(')') + 1);

                        //get compressed string
                        string compressedString = tempLine.Substring(0, spaces);

                        //decompress string and add to final decompressedStr
                        for (int i = 0; i < multiply; i++)
                        {
                            decompressedStr += compressedString;
                        }

                        //remove compressedString
                        tempLine = tempLine.Remove(0, spaces);
                    }
                    

                }
            }

            Console.WriteLine(decompressedStr);
            return decompressedStr.Length;
        }

        public static int dayNinePartTwo(string file)
        {
            string[] dayNineLines = System.IO.File.ReadAllLines(file);

            string decompressedStr = "";

            foreach (string line in dayNineLines)
            {
                string tempLine = line;

                decompressedStr += expand(tempLine);
            }

            Console.WriteLine(decompressedStr);
            return decompressedStr.Length;
        }

        public static string expand(string s)
        {
            string tempLine = s;
            string decompressedStr = "";

            while (tempLine.Length > 0)
            {
                //end case where there is no '(' left
                if (!tempLine.Contains('('))
                {
                    decompressedStr += tempLine;
                    break;
                }

                //Check if any strings before the '(' ) and remove decompressed part
                if (tempLine.Substring(0, tempLine.IndexOf('(')).Length > 0)
                {
                    decompressedStr += tempLine.Substring(0, tempLine.IndexOf('('));
                    tempLine = tempLine.Remove(0, tempLine.IndexOf('('));
                }
                //We are at a '(' its time to decompress and then remove decompressed part
                else
                {
                    //get marker data
                    int spaces = int.Parse(tempLine.Substring(1, tempLine.IndexOf('x') - 1));
                    int multiply = int.Parse(tempLine.Substring(tempLine.IndexOf('x') + 1, (tempLine.IndexOf(')') - 1) - (tempLine.IndexOf('x'))));

                    //remove marker ex: (3x3)afdsa => afdsa
                    tempLine = tempLine.Remove(0, tempLine.IndexOf(')') + 1);

                    //get compressed string
                    string compressedString = tempLine.Substring(0, spaces);

                    //decompress string and add to final decompressedStr
                    for (int i = 0; i < multiply; i++)
                    {
                        decompressedStr += compressedString;
                    }

                    //remove compressedString
                    tempLine = tempLine.Remove(0, spaces);
                }


            }

            if (decompressedStr.Contains("("))
            {
                decompressedStr = expand(decompressedStr);
            }

            return decompressedStr;
        }

        #endregion
    }
}


