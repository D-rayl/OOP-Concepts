using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = GetSize(), target = -1;
            while (size < 0)
            {
                size = GetSize();
            }
            int[,] matrix = new int[size, size];
            Fill(ref matrix, size);
            Display(ref matrix,size);
            Console.WriteLine("\n");
            Sort(matrix, size);
            Display(ref matrix,size);
            while (target < 0)
            {
                Console.Write("Search for: ");
                if (!(Int32.TryParse(Console.ReadLine(), out target)))
                {
                    target = -1;
                }
            }
            bool find = StepWiseSearch(matrix, size, target);
            Console.WriteLine(find);
            Console.Read();
        }
        /**
         * Stepwise search, array must be sorted
         * starts by checking if target value is within the range of the array
         * loops, checking position (initialised) valid in the array
         * if position less than target increment the rows by 1
         * else if position greater than target decrement the columns by 1
         * else return true, target found, if not return false
         * */
        public static bool StepWiseSearch(int[,] m, int size, int target)
        {
            if(!(target < m[0,0] || target > m[size-1, size - 1]))
            {
                int row = 0;
                int col = size - 1;
                while(row <= size-1 && col >= 0)
                {
                    Console.WriteLine("Row: " + row + " Value: " + m[row, col]);
                    if(target == m[row, col]){
                        Console.WriteLine("Found at row: "+row+", col: "+col);
                    }
                    if(m[row,col] < target)
                    {
                        row++;
                    }
                    else if(m[row,col] > target)
                    {
                        col--;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /**
         * Sort for 2D Array
         * Uses 4 FOR loops checking off in a linear fashion 
         * the values at the outer 2 most loop
         * with the values found at the inner 2 loops 
         * */
        public static void Sort(int[,] m, int size)
        {
            int temp;
            for(int y = 0; y < size; y++)
            {
                for(int x = 0; x < size; x++)
                {
                    for(int i = 0; i < size; i++)
                    {
                        for(int j = 0; j < size; j++)
                        {
                            if(m[y,x] < m[i, j])
                            {
                                temp = m[y, x];
                                m[y, x] = m[i, j];
                                m[i, j] = temp;
                            }
                        }
                    }
                }
            }
        }
       
        /**
         * Fill method, generates a random number, ensuring
         * no duplicate values, with the use of a list
         * and iserts them into the 2D Array. 
         * */
        public static void Fill(ref int[,] m, int size)
        {
            Random r = new Random();
            List<int> nums = new List<int>();

            for (int row = 0; row < size; row++)
            {
                for(int col = 0; col < size; col++)
                {
                    int next = r.Next(10,100);
                    if (nums.Contains(next))
                    {
                        col--;
                    }
                    else
                    {
                        nums.Add(next);
                        m[col, row] = next; 
                    }
                }
            }
        }

        /**
         * Display 2D Array method
         * Use 2 loop to iterate through
         * the Array printing each value
         * */
        public static void Display(ref int[,] m, int size)
        {
            bool head = true;
            for(int row = 0; row < size; row++)
            {
                
                for (int col = 0; col < size; col++)
                {
                    if (head)
                    {
                        Console.Write("       ");
                        for(int i = 0; i < size; i++)
                        {
                            Console.Write("Col "+i+"  ");
                        }
                        head = false;
                        Console.WriteLine();
                    }
                    if(col == 0)
                    {
                        Console.Write("Row " + row + ": ");
                    }
                   
                    Console.Write("["+m[row, col]+"]   ");
                }
                
                Console.WriteLine("\n");
            }
        }

        public static int GetSize()
        {
            Console.Write("Enter Matrix size: ");
            
            int s;
            if (!(Int32.TryParse(Console.ReadLine(), out s)))
            {
                s = -1;
            }
            return s;
        }
    }
}
