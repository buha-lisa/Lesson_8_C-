using System;
using System.Runtime.Intrinsics.X86;

namespace sc8
{
    internal class Array : IOutput, IMath, ISort
    {
        public int[] Ints = { 3, 5, 6, 7, 8, 1 };

        //1
        public void Show()
        {
            for (int i = 0; i < Ints.Length; i++)
            {
                Console.Write($"{Ints[i]} ");
            }
            Console.WriteLine("\n");
        }
        public void Show(string info)
        {
            for (int i = 0; i < Ints.Length; i++)
            {
                Console.Write($"{Ints[i]}");
            }
            Console.WriteLine($"\n{info}");
        }

        //2
        public int Max()
        {
            int max = Ints[0];
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] > max) max = Ints[i];
            }
            return max;
        }
        public int Min()
        {
            int min = Ints[0];
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] < min) min = Ints[i];
            }
            return min;
        }
        public float Avg()
        {
            int avg = 0;
            for (int i = 0; i < Ints.Length; i++)
            {
                avg += Ints[i];
            }
            return avg/Ints.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] ==  valueToSearch) return true; 
            }
            return false;
        }

        //3
        public void SortAsc()
        {
            for (var i = 1; i < Ints.Length; i++)
            {
                for (var j = 0; j < Ints.Length - i; j++)
                {
                    if (Ints[j] > Ints[j + 1])
                    {
                        int temp = Ints[j];
                        Ints[j] = Ints[j+1];
                        Ints[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Ints.Length; i++)
            {
                Console.Write($"{Ints[i]} ");
            }
            Console.WriteLine("\n");
        }
        public void SortDesc() 
        {
            for (var i = 1; i < Ints.Length; i++)
            {
                for (var j = 0; j < Ints.Length - i; j++)
                {
                    if (Ints[j] < Ints[j + 1])
                    {
                        int temp = Ints[j];
                        Ints[j] = Ints[j + 1];
                        Ints[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Ints.Length; i++)
            {
                Console.Write($"{Ints[i]} ");
            }
            Console.WriteLine("\n");
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                for (var i = 1; i < Ints.Length; i++)
                {
                    for (var j = 0; j < Ints.Length - i; j++)
                    {
                        if (Ints[j] > Ints[j + 1])
                        {
                            int temp = Ints[j];
                            Ints[j] = Ints[j + 1];
                            Ints[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (var i = 1; i < Ints.Length; i++)
                {
                    for (var j = 0; j < Ints.Length - i; j++)
                    {
                        if (Ints[j] < Ints[j + 1])
                        {
                            int temp = Ints[j];
                            Ints[j] = Ints[j + 1];
                            Ints[j + 1] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < Ints.Length; i++)
            {
                Console.Write($"{Ints[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}
