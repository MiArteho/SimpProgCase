using System;

namespace ConsoleAppThree
{
    class Human
    {
        public string name;
        public string surname;
        public string group;
        public int[] marks;
        public float avgMark;
        /*int[] disc1Mark;
        int[] disc2Mark;
        int[] disc3Mark;
        int[] disc4Mark;
        int[] disc5Mark;
        int[][] disciplins;
        */

        public Human(string _name, string _surname, string _group,int[] _marks)
        {
            name = _name;
            surname = _surname;
            group = _group;
            marks = _marks;
            CountMarks();
            //disciplins = new int[][] { disc1Mark, disc2Mark, disc3Mark, disc4Mark, disc5Mark };
        }
        public void CountMarks()
        {
            int summa = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                summa = summa + marks[i];
            }
            avgMark = (float)summa / (float)marks.Length;
        }
        public void ShowInfo()
        {
            Console.WriteLine(name+" "+surname+" "+group+" "+marks);
        }
    }
    class Program
    {
        static void first() {
            int a, b;
            Console.Write("Type a numper one.. ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Type a numper two.. ");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.Write("They are equal!");
            }
            else if (a > b)
            {
                Console.Write("First number more then second number!");
            }
            else
            {
                Console.Write("Second number more then first number!");
            }
        }

        static void second(){
            int a, b, c;
            b = 5;
            c = 10;
            Console.WriteLine("Type any number!");
            a = int.Parse(Console.ReadLine());
            if (a > b && a < c)
            {
                Console.WriteLine("More then five too low when ten!");
            }
            else
            {
                Console.WriteLine("Uncorrect number!");
            }
        }
        static void third()
        {
            int a, b, c;
            b = 5;
            c = 10;
            Console.WriteLine("Type any number!");
            a = int.Parse(Console.ReadLine());
            if (((a == b)  || (a == c)))
            {
                Console.WriteLine("Are equal first or second!");
            }
            else
            {
                Console.WriteLine("Uncorrect number!");
            }
        }
        static void fourth()
        {
            int a;
            Console.WriteLine("Type any amount of money!");
            a = int.Parse(Console.ReadLine());
            if (a < 100) {
                a = a + a * 5 / 100;
            }
            else if((a<200)&&(a>=100)){
                a = a + a * 7 / 100;
            }
            else
            {
                a = a + a / 10;
            }
            Console.WriteLine(a.ToString(), " Total amount to be credited!");
        }
        static void fifth()
        {
            int a;
            Console.WriteLine("Type any amount of money!");
            a = int.Parse(Console.ReadLine());
            if (a < 100)
            {
                a = a + a * 5 / 100;
            }
            else if ((a < 200) && (a >= 100))
            {
                a = a + a * 7 / 100;
            }
            else
            {
                a = a + a / 10;
            }
            a = a + 15;                                                                  // ADD 15$$ Bonuss
            Console.WriteLine(a.ToString(), " Total amount to be credited!");
        }
        static void sixth()
        {
            int a, b,c;
            Console.WriteLine("Type any number!");
            Console.WriteLine("1 Summ");
            Console.WriteLine("2 Sub");
            Console.WriteLine("3 Mul");

            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Summ operation:");
                    Console.WriteLine("Type first number!");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type second number!");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine("Sub operation:");
                    Console.WriteLine("Type first number!");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type second number!");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine("Mul operation:");
                    Console.WriteLine("Type first number!");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type second number!");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                default:
                    Console.WriteLine("not determined operation");
                    break;
            }
        }
        static void seventh()
        {
            sixth();
        }
        static void eith()
        {
            int a, b;
            Console.WriteLine("Type total month");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Type total money");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                a = a + a * 7 / 100;
            }
            Console.WriteLine($"Total money after operation: {a}");
        }
        static void nineth()
        {
            int a, b;
            Console.WriteLine("Type total month");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Type total money");
            a = int.Parse(Console.ReadLine());
            while (b > 0)
            {
                b--;
                a = a + a * 7 / 100;
            }
            Console.WriteLine($"Total money after operation: {a}");
        }
        static void tenth()
        {
            int a = 9, b = 9;
            int i,j;
            int[,] arrA = new int[10,10];
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <=b; j++)
                {
                    arrA[i,j] = i * j;
                    Console.Write(arrA[i,j].ToString() + "\t ");
                }
                Console.WriteLine();
            }
        }
        static void eleventh()
        {
            int a, b;
            Console.WriteLine("Type two numbers:");
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (((a>=0) && (a<=10)) && ((b >= 0) && (b <= 10)))
                {
                    a = a * b;
                    break;
                }
                else
                {
                    Console.WriteLine("Type an anouther numbers!");
                }
            }
            Console.WriteLine($"Answer:   {a}");
        }

        //   Not work as must working 12
        static void twelth()
        {
            int[,] arr = new int[11, 11];
            int[] arrStrok = new int[11];
            int[] arrStolb = new int[11];
            int i=0, j=0;
            Random rnd = new Random();
            ///For mul ********
            for (int k = 0; k < 10; k++)
            {
                arrStolb[k] = 1;
            }
            ///Main Part of program
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                    arrStolb[j] = arrStolb[j] * arr[i,j];
                    arrStrok[i] = arrStrok[i] + arr[i, j];
                    Console.Write(arr[i, j]+"\t ");
                }
                Console.WriteLine();
                //arrStrok[i] = arrStrok[i] + arr[i,j];
            }
            Console.WriteLine();
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(arrStrok[i]);
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(arrStolb[i]);
            }
            int max = arr[0, 0];
            for (int p = 0; p < 10; p++)
            {
                for (int q = 0; q < 10; q++)
                {
                    if (p==q)
                    {
                        if (arr[p, q] > max)
                        {
                            max = arr[p, q];
                        }
                        
                    }
                }
            }
            Console.WriteLine($"Maximum diagonal:  {max}");
        }
        /// <summary>
        /// If two probel --->> program working not correctly! ---------not fixed
        /// </summary>
        static void threeteenth()
        {
            string str="";
            int len;
            Console.WriteLine("Type any sentence");
            str =Console.ReadLine();
            str = str.Trim();
            ////////string[] arrayStr = str.Split(" ");     //////this is advice
            ////////Console.WriteLine(arrayStr.Length);
            //len = str.Length;
            len = 1;
            //string[] words = str.Split(new char[] { ' ' });
            Console.WriteLine($"Total words: {len}");
            char[] simb;
            simb = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                //if ((simb[i] == ' ') && (simb[i-1] != ' ')&& (simb[i+1] != ' '))
                if (simb[i] == ' ')
                {
                    len++;
                }
                Console.WriteLine(simb[i]);
            }
            Console.WriteLine($"Total words: {len}");
        }
        /// <summary>
        
        /// </summary>
        static void fourteenth()
        {
            int[] arr = new int[] {15, 22, 46, 50, 14, 5};
            int j = 0;
            int v = 0;
            int min = 0;
            int size=arr.Length;
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] arrAsc = new int[size];
            int[] RetypeMass = new int[size];
            min = arr[0];
            for (int i = 0; i < size; i++)
            {
                for (int n = i + 1; n < size; n++)
                {
                    if (arr[i] > arr[n])
                    {
                        min = arr[i];
                        arr[i] = arr[n];
                        arr[n] = min;
                    }
                }
            }

            /*for (int i = 0; i < size; i++)
            {
                for (int n = 0; n < size; n++)
                {
                    if (min > arr[n])
                    {
                        RetypeMass[l]=arr[n];
                        arr[n] = 100;
                        l++;
                    }
                    Console.WriteLine(RetypeMass[i]);
                }
                l = 0;
                    
            }
            */
            for (int i = 0; i < 6; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[j] = arr[i];
                    j++;
                }
                else
                {
                    arr2[v] = arr[i];
                    v++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < v; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

        }
        static void fiveteenth()
        {
            int[] arr = new int[10];
            int min,max;
            for (int i = 0; i < 9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            min = arr[0];
            max = arr[8];
            for (int i = 0; i < 9; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            
            }
            Console.WriteLine($"max = {max} min = {min}  Razn: {max-min}");
        }
        static void sixteenth()
        {
            int[] arr = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 200);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n\n");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0 && arr[i]<125)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total: {count}");
        }
        static void seventeenth()
        {
            //int[] mass1 = new int;
            Human person = new Human("Kiri","Nuni","Tp10",fillArray(10));
            Human person1 = new Human("Katya", "Tolskya", "Tp10", fillArray(10));
            Human person2 = new Human("Kolya", "Tomskij", "Tp10", fillArray(10));
            Human[] arrHyman = { person, person1, person2 };
            for (int i = 0; i < arrHyman.Length; i++)
            {
                if (arrHyman[i].avgMark<2.5f)
                {
                    Console.WriteLine(arrHyman[i].name + " "+ arrHyman[i].surname+" " + arrHyman[i].avgMark);
                }
            }
            //arrHyman[1].ShowInfo();

            static int[] fillArray(int length)
            {
                int[] array = new int[length];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 6);
                }
                //person.ShowInfo();
                return array;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Type from 1 to 17!");
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    first();
                    break;
                case 2:
                    second();
                    break;
                case 3:
                    third();
                    break;
                case 4:
                    fourth();
                    break;
                case 5:
                    fifth();
                    break;
                case 6:
                    sixth();
                    break;
                case 7:
                    seventh();
                    break;
                case 8:
                    eith();
                    break;
                case 9:
                    nineth();
                    break;
                case 10:
                    tenth();
                    break;
                case 11:
                    eleventh();
                    break;
                case 12:
                    twelth();
                    break;
                case 13:
                    threeteenth();
                    break;
                case 14:
                    fourteenth();
                    break;
                case 15:
                    fiveteenth();
                    break;
                case 16:
                    sixteenth();
                    break;
                case 17:
                    seventeenth();
                    break;
                default:
                    Console.WriteLine("Uncorrect number!");
                    break;

            }
            
        }


    }
}
