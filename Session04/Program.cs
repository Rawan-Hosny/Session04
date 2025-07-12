namespace Session04
{
    internal class Program
    {
     
            #region Functions (Q1)
           static void Swap_P_Value(int x, int y)
            {
                int Temp = x;
                x = y;
                y = Temp;
            }

        static void Swap_P_ref(ref int x, ref int y)
            {
                int Temp = x;
                x = y;
                y = Temp;
            }
        #endregion

        #region Functions (Q2)
        static  int SumArray_p_value(int[] Arr)
            {
                int Sum = 0;
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }
                return Sum;
            }

        static int SumArray_p_ref(ref int[] Arr)
            {
                int Sum = 0;
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }
                return Sum;
            }
        #endregion

        #region Function (Q3)
        static void sum_sup(int num01, int num02, int num03, int num04, out int Summtion, out int Suptracting)
            {
                Summtion = num01 + num02;
                Suptracting = num03 - num04;

                Console.WriteLine($"Summtion First two number = {Summtion}");
                Console.WriteLine($"Suptracting next two number = {Suptracting}");

            }
        #endregion

        #region Function (Q4)
        static int SumDigitsOfnums(int Number)
            {
                int Sum = 0;
                while (Number != 0)
                {
                    Sum += Number % 10;
                    Number /= 10;
                }
                return Sum;
            }

        #endregion

        #region Function (Q5)
        static bool IsPrime(int Number)
            {
                if (Number <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(Number); i++)
                    if (Number % i == 0)
                        return false;

                return true;

            }

        #endregion

        #region Function (Q6)
         static int[] MinMaxArray(int[] Arr)
            {
                int Min = Arr[0];
                int Max = Arr[0];
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Max < Arr[i])
                    {
                        Max = Arr[i];
                    }
                    if (Min > Arr[i])
                    {
                        Min = Arr[i];
                    }

                }
                int[] Result = { Max, Min };
                return Result;

            }

            #endregion

            #region Function (Q7)
            static long FactorialNumber(int Number)
            {
                if (Number <= 1)
                    return 1;
                int factorial = 1;
                for (int i = 1; i <= Number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }

            #endregion

            #region Function (Q8)
            static string ChangeChar(string Text, int index, char NewChar)
            {
                if (index < 0 || index >= Text.Length)
                    return Text;
                char[] chars = Text.ToCharArray();// ToCharArray()use to convert string to Array
                chars[index] = NewChar;
                return new string(chars);
            }
            #endregion

            #region Function (Q9)
            static void IdentityMatrix(int Number)
            {
                for (int i = 0; i < Number; i++)
                {
                    for (int j = 0; j < Number; j++)
                    {
                        if (i == j)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            #endregion

            #region Function (Q10)
            static int sumarray(int[] arr)
            {
                int sum = 0;
                arr = new[] { 10, 20, 30 };
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
            #endregion


            static void Main(string[] args)
            {


            #region Q1
            /*
             1- Explain the difference between passing (Value type parameters) 
             by value and by reference then write a suitable c# example. 
             */

            //Explain

            // passing (Value type parameters) by value:
            // passing (Value type parameters) by reference:

            //EX(passing (Value type parameters) by value)
            // int A = 4;int B = 9;
            // Console.WriteLine($"A={A},B={B}");
            // Console.WriteLine("A and B after S");
            // Swap_P_Value(A, B);               
            // Console.WriteLine($"A={A},B={B}");

            //EX(passing (Value type parameters) by ref)
            // int a = 4;int b = 9;
            // Console.WriteLine($"a={a},b={b}");
            // Console.WriteLine("a and a after Swap");
            // Swap_P_ref(ref a,ref b);
            // Console.WriteLine($"A={a},B={b}");
            #endregion

            #region Q2
            /*
             2- Explain the difference between passing (Reference type 
             parameters) by value and by reference then write a suitable c# 
             example.
            */

            //Explain

            //passing (Reference type parameters) by value:
            //passing (Reference type parameters) by reference:

            //passing (Reference type parameters) by value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray_p_value(Numbers));
            //Console.WriteLine(Numbers[0]);

            //passing (Reference type parameters) by reference
            //int[] Number = { 1, 2, 3 }; 
            //Console.WriteLine(SumArray_p_ref(ref Number));
            //Console.WriteLine(Number[0]);
            #endregion

            #region Q3
            /*
             3- Write a c# Function that accept 4 parameters from user and 
             return result of summation and subtracting of two numbers
             */
            //Console.Write("Enter the (1)Number: ");
            //int num01 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the (2)Number: ");
            //int num02 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the (3)Number: ");
            //int num03 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the (4)Number: ");
            //int num04 = int.Parse(Console.ReadLine());

            //sum_sup( num01,  num02,  num03,  num04, out int Summtion, out int Suptracting);

            #endregion

            #region Q4
            /*
             4- Write a program in C# Sharp to create a function to calculate the sum of the 
             individual digits of a given number.
              Output should be like 
              Enter a number: 25 
              The sum of the digits of the number 25 is: 7
             */

            Console.Write("Enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of the number {Number} is: {SumDigitsOfnums(Number)}");

            #endregion

            #region Q5
            /*  
             5- Create a function named "IsPrime", which receives an integer number 
              and retuns true if it is prime, or false if it is not
             */

            // Console.Write("Enter Number: ");
            // int Number = int.Parse(Console.ReadLine());
            // Console.WriteLine($"The Number Is Prime? {IsPrime(Number)}");
            #endregion

            #region Q6
            /*
             6- Create a function named MinMaxArray, to return the minimum and 
             maximum values stored in an array, using reference parameters
             */
            // int[] Arr = { 2, 4, 56, 7, 8, 9 };
            // int[] Result = MinMaxArray(Arr);
            // Console.WriteLine("the Max: "+Result[0]);
            // Console.WriteLine("The Min: "+Result[1]);
            #endregion

            #region Q7
            /*
             7- Create function to calculate the factorial of the number specified as 
             parameter
             */

            // Console.Write("Enter Number: ");
            // int Number = int.Parse(Console.ReadLine());
            // Console.WriteLine($"The Factorial Of The Number= {FactorialNumber(Number)}");
            #endregion

            #region Q8
            /*
             * 8- Create a function named "ChangeChar" to modify a letter in a certain 
            position(0 based) of a string, replacing it with a different letter
            */

            //Console.WriteLine("Enter String: ");
            //string Text = Console.ReadLine();
            //
            //Console.WriteLine("Enter Idex: ");
            //int index = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine("Enter new char: ");
            //char NewChar = char.Parse(Console.ReadLine());
            //
            //Console.WriteLine($"The New String : {ChangeChar(Text, index, NewChar)}");
            #endregion

            #region Q9
            /*
             9- . Write a program that prints an identity matrix using for loop, in 
              other words takes a value n from the user and shows the identity table 
              of size n * n.
             */
            //Console.Write("Enter Number: ");
            //int Number = int.Parse(Console.ReadLine());
            //IdentityMatrix(Number);
            #endregion

            #region Q10
            /*
             10- Write a program in C# Sharp to find the sum of all elements of the 
                array
             */

            //int[] Numbers = { 1, 3, 5, 7, 9, 7 };
            //Console.WriteLine($"the Sum Of Array= {sumarray(Numbers)}");

            #endregion

            #region Q11
            /*
             11- - Write a program in C# Sharp to merge two arrays of the same size 
             sorted in ascending order
             */
            //int[] Arr1 = { 10, 20, 30, 40, 50 };
            //int[] Arr2 = { 100, 110, 90, 80, 70 };

            //int[] Merged = new int[Arr1.Length + Arr2.Length];

            //Arr1.CopyTo(Merged, 0);              
            //Arr2.CopyTo(Merged, Arr1.Length);     

            //Array.Sort(Merged);

            //Console.WriteLine("Merged and sorted array:");
            //for (int i = 0; i < Merged.Length; i++)
            //{
            //    Console.Write(Merged[i] + " "); 
            //}
            //Console.WriteLine();  

            #endregion

            #region Q12
            /*
             12- Write a program in C# Sharp to find maximum and minimum element in an 
              array
             */
            //int[] Arr = new []{ 1, 3, 4, 5, 66, 99, 7, 10 };
            //int Min = Arr[0];
            //int Max = Arr[0];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (Max < Arr[i])
            //    {
            //        Max = Arr[i];
            //    }
            //    if (Min > Arr[i])
            //    {
            //        Min = Arr[i];
            //    }

            //}
            //Console.WriteLine("The Max= "+Max);
            //Console.WriteLine("the Min= "+Min);
            #endregion

            #region Q13
            /*
             13- Write a program in C# Sharp to find the second largest element in an 
              array
             */

            //int[] arr = { 10, 20, 30, 40, 50 };

            //if (arr.Length < 2)
            //{
            //    Console.WriteLine("The Array Have no Two Element");
            //}

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //foreach (int num in arr)
            //{
            //    if (num > largest)
            //    {
            //        secondLargest = largest;  
            //        largest = num;
            //    }
            //    else if (num > secondLargest && num != largest)
            //    {
            //        secondLargest = num;
            //    }
            //    #endregion
            //}
            //Console.WriteLine($"second Largest number = {secondLargest}");
            #endregion

            #region Q14
            /*
             14- Consider an Array of Integer values with size N, having values as 
              in this Example
             */


            //Console.WriteLine("Enter the size of the array (N): ");
            //int N = int.Parse(Console.ReadLine());

            //int[] arr = new int[N];
            //Console.WriteLine("Enter the array elements: ");
            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Dictionary<int, int> elementPositions = new Dictionary<int, int>();
            //int maxDistance = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (elementPositions.ContainsKey(arr[i]))
            //    {

            //        int distance = i - elementPositions[arr[i]] - 1;
            //        maxDistance = Math.Max(maxDistance, distance);
            //    }
            //    else
            //    {

            //        elementPositions[arr[i]] = i;
            //    }
            //}

            //Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);


            #endregion

            #region Q15
            /*
             5 Given a list of space separated words, reverse the order of the words
             */
            //Console.Write("Enter the separated words: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));

            #endregion


            #region 16. Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array:
            //int [,] Matrix01 = new int[3, 3];
            //int [,] Matrix02 = new int[3, 3];
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.Write($"Please Enetr Element {rows},{col}: ");
            //        Matrix01[rows, col] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Matrix02[rows, col] = Matrix01[rows, col]; // Copy elements from Matrix01 to Matrix02
            //    }
            //}
            //Console.WriteLine("The Matrix02: ");
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.Write(Matrix02[rows,col]+" ");
            //    }
            //}
            #endregion
            #region 17. Write a Program to Print One Dimensional Array in Reverse Order:
            //int[] arr = { 10, 20, 30, 40, 50 };
            // First Solution:
            //Console.WriteLine("The Reverse Order: ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //Console.Write(arr[i] + " ");
            //}

            // Second Solution:
            //for (int i = 0; i < arr.Length / 2; i++)  //   i need to loop only half the array length
            //{
            //int temp = arr[i];
            //arr[i] = arr[arr.Length - 1 - i]; // Swap elements 
            //arr[arr.Length - 1 - i] = temp; // Swap elements
            //}
            //Console.WriteLine();
            //Console.WriteLine("The Reverse Order: ");
            // Print the reversed array Phisically 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //Console.Write(arr[i] + " ");
            //}
            #endregion
        }
            }
}
