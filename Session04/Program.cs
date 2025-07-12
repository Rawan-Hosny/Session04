namespace Session04
{
    internal class Program
    {
        
            //void sum_sup(int num01, int num02, int num03, int num04, out int Summtion, out int Suptracting)
            //{
            //    Summtion = num01 + num02;
            //    Suptracting = num03 - num04;

            //    Console.WriteLine($"Summtion First two number = {Summtion}");
            //    Console.WriteLine($"Suptracting next two number = {Suptracting}");

            //}
            //static int sumArray(params int[] arr)
            //{
            //    int sum = 0;
            //    arr= new[] {10,20,30};
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}
            //static int sumArray(int[] arr)
            //{
            //    int sum = 0;
            //    arr = new[] { 10, 20, 30 };
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}

            //static int sumArray( ref int[] arr)
            //{
            //    int sum = 0;
            //    arr[0] = 100;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}
            //static int sumArray(int[] arr)
            //{
            //    int sum = 0;
            //    arr[0] = 100;
            //        for(int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}
            //static void Swap(ref int x,ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}

            //static void Swap(int x,int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}
            //static void printshape(int count)
            // {
            //     //body
            //     for(int i =1; i <= count; i++)
            //     {
            //         Console.WriteLine(i);
            //     }

            // }
            static void Main(string[] args)
            {
                #region One D Array
                // int[] Numbers;
                //// Declare for refrance (Pointer) From Type (Array of integers)
                //// Numbers can refer to object from typ "array of intgers"
                //// Numbers Refer to Null

                ////  8 bytes are located at stack for reference'Numbers'
                ////  0 bytes are located at heap

                //// Numbers= new int[Size];
                // Numbers = new int[5];
                ////new
                ////1. allocat the number of required Bytes for the object At Heap (4 bytes * 5)
                ////2. Initialized the Allocated bytes with the default value of datatypes (int -> 0)
                ////3.call user defined constructor if Exists
                //// Assign the object to the Reference ' numbers'

                //Console.WriteLine(Numbers[0]);//0
                //Console.WriteLine(Numbers[1]);//0
                //// add value
                //Numbers[0] = 12;
                //Numbers[1] = 13;
                //Numbers[2] = 16;
                //Numbers[3] = 10;
                //Numbers[4] = 40;

                //Console.WriteLine(Numbers[0]);//12
                //Console.WriteLine(Numbers[1]);//13

                //int[] Numbers01 = { 1, 2, 34, 5, 7 };
                //int[] Numbers02 = new int[4] { 1, 3, 4, 5 };
                //int[] Numbers03 = new int[3];


                //for (int i =0; i < 5; i++)
                //{
                //    Console.WriteLine($"Enter value index( {i} )" );
                //    Numbers[i] = int.Parse(Console.ReadLine());
                //}

                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write($"{Numbers[i]}," );

                //}
                // one d array 
                //Console.WriteLine(Numbers.Length);// size
                //Console.WriteLine(Numbers.Rank);// Dimention
                #endregion

                #region Two D Array Rectangel
                //Two d Array

                //int[,] Marks = new int[3, 3];
                //Marks[0, 0] = 33;
                //Marks[0, 1] = 33;
                //Marks[0, 2] = 33;

                //Marks[1, 0] = 23;
                //Marks[1, 1] = 23;
                //Marks[1, 2] = 23;

                //Marks[2, 0] = 13;
                //Marks[2, 1] = 13;
                //Marks[2, 2] = 13;

                //Console.WriteLine(Marks[0,0]);
                //Console.WriteLine(Marks[0, 1]);
                //Console.WriteLine(Marks[0, 2]);
                //by loop

                //for(int i = 0; i < 3; i++)//Row
                //{
                //    for(int j = 0; j < 3; j++)//col
                //    {
                //        Console.WriteLine($"Enter index({i},{j})");
                //        Marks[i, j] = int.Parse(Console.ReadLine());
                //    }
                //}

                //for (int i = 0; i < 3; i++)//Row
                //{
                //    for (int j = 0; j < 3; j++)//col
                //    {
                //        Console.Write(Marks[i,j]+" ");

                //    }
                //    Console.WriteLine();
                //}

                #endregion

                #region Two D Array Jaddeg
                //Two D Array Jaddeg
                //int[][] marks = new int[3][];
                //marks[0] = new int[2];
                //marks[1] = new int[3];
                //marks[2] = new int[4];
                //for (int i =0; i<3;i++) 
                //{ 
                //    for(int j = 0; j < marks[i].Length; j++)
                //    {
                //        Console.WriteLine($"Enter value index ({i},{j})");
                //        marks[i][j] = int.Parse(Console.ReadLine());
                //    }
                //}

                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < marks[i].Length; j++)
                //    {
                //        Console.Write(marks[i] [j]+ " ");
                //    }
                //    Console.WriteLine();
                //}

                //int[][] marks = new int[3][];
                //marks[0] = new int[] {1,5};
                //marks[1] = new int[] {1,4,7};
                //marks[2] = new int[] {4,6,88,9};
                #endregion

                #region Functions Prototype And Calling
                // Function: block of code that have name if  u need excute this code u must call the function by name 
                //Dry
                // function prototype
                //1. signiture
                //1.1 name
                //1.2 return type
                //1.3 prameter 
                //2. body : code 
                //call function
                // printshape(20);
                #endregion

                #region passing by value 
                //passing by value 
                // passing by refrence

                //passing parametar by valuetype
                //1.passing by value 
                //int a = 3;
                //int b = 4;
                //Console.WriteLine(a + " " + b);
                //Swap(a, b);
                //Console.WriteLine("a,b After Swap= ");
                //Console.WriteLine(a+" "+b);
                //2.passing by refrence

                //int a = 3;
                //int b = 4;
                //Console.WriteLine(a + " " + b);
                //Swap(ref a,ref b);
                //Console.WriteLine("a,b After Swap= ");
                //Console.WriteLine(a + " " + b);
                #endregion

                #region Passing by reference
                // Passing Parameter reference type
                //1.passing value
                // int[] Numbers = { 2, 4, 6, 5 };
                //int result= sumArray(Numbers);
                // Console.WriteLine(result);

                //2. passing by reference //ala hasab el examble

                //int[] Numbers = { 2, 4, 6, 5 };
                //int result = sumArray(ref Numbers);
                //Console.WriteLine(result);
                #endregion

                #region Passing by out
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

                #region Params
                //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };

                //Console.WriteLine(sumArray(1,2,3,4,4,5,7));
                #endregion
            }
        }
}
