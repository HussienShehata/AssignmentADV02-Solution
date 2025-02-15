using System.Collections;

namespace AssignmentADV02
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

            #region Q1

            //int size;
            //int numberOfQueries;

            //Console.WriteLine("Enter Size of array : ");
            //int.TryParse(Console.ReadLine(), out size);

            //Console.WriteLine("Enter number of queries : ");
            //int.TryParse(Console.ReadLine(), out numberOfQueries);

            //int[] arr = new int[size];

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Console.WriteLine("Enter numbers in the array :");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //Console.Clear();
            //Helper.QueryToArray(arr, numberOfQueries);

            #endregion


            #region Q2

            //int n;
            //bool isPalindrome;
            //Console.WriteLine("Enter the numbers of the array : ");
            //int.TryParse(Console.ReadLine(), out n);

            //int[] arr = [1, 2, 3, 2, 1];

            //isPalindrome = Helper.Palindrome(arr);
            //Console.WriteLine(isPalindrome);


            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine($"{ queue.Capacity} , {queue.Count}");
            //queue.Enqueue(1);
            //queue.Enqueue(2); 
            //queue.Enqueue(3); 
            //queue.Enqueue(4);
            //Console.WriteLine($"{queue.Capacity} , {queue.Count}");

            //Console.Clear();

            //Helper.ReverseByStack(queue);


            #endregion

            #region Q4

            //Stack<string> stack = new Stack<string>();
            //stack.Push("[");
            //stack.Push("(");
            //stack.Push(")");
            //stack.Push("]");
            //stack.Push("{");
            //stack.Push("}");

            //foreach (string item in stack)
            //{
            //    Console.Write($"{item}");
            //}

            //Console.WriteLine("\n----------------");

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("[");
            //queue.Enqueue("("); 
            //queue.Enqueue(")");
            //queue.Enqueue("]");
            //queue.Enqueue("{");
            //queue.Enqueue("}");

            //Console.Write($"queue is :");
            //foreach (string item in queue)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine("\n----------------");

            //Helper.ParenthesesCheck(stack);


            #endregion

            #region Q5

            //int[] arr = { 1, 2, 3, 3, 2, 5, 6, 4, 5, 6 };
            //int[] newArr= Helper.RemoveDuplication<int>(arr);

            //foreach(int item in  newArr)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion


            #region Q6

            //ArrayList arrayList = new ArrayList(10) {1,2,3,4,5,6,7,8,9,10 };
            //ArrayList arrayList2 = new ArrayList();

            //arrayList2=Helper.RemoveOdd(arrayList);

            //for (int i = 0; i < arrayList2.Count; i++)
            //{
            //    Console.Write($"{arrayList2[i]} ");

            //}

            //Console.WriteLine($"\n{arrayList2.Capacity},{arrayList2.Count}");




            #endregion


            #region Q7

            //Queue queue = new Queue(3);
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Q8

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int target;
            //Console.WriteLine("Enter the target integer : ");
            //int.TryParse(Console.ReadLine(), out target);

            //Helper.TargetInteger(stack, target);



            #endregion

            #region Q9

            //int n1, n2;

            //Console.Write("Enter number of elements in first array : ");
            //int.TryParse(Console.ReadLine(), out n1);

            //Console.Write("Enter number of elements in second array : ");
            //int.TryParse(Console.ReadLine(), out n2);
            //int[] arr1 = new int[n1];
            //int[] arr2 = new int[n2];
            //int[] arr3 ;

            //Console.WriteLine("Enter the elements of the first array :");
            //for (int i = 0; i < arr1.Length; i++)
            //{ 
            // int.TryParse(Console.ReadLine(), out arr1[i]);
            //}


            //Console.WriteLine("Enter the elements of the second array :");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr2[i]);
            //}
            //arr3=Helper.IntersectionOfArrays<int>(arr1, arr2);

            //Console.WriteLine("The intersection between two arrays are : ");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write($"{arr3[i]} ");
            //}


            #endregion


            #region Q10

            //ArrayList arrayList = new ArrayList(5) {1,2,3,4,5 };
            //int sum;
            //Console.WriteLine("Enter the target sum : ");

            //int.TryParse(Console.ReadLine(), out sum);

            //ArrayList arrayList1 = new ArrayList();
            //arrayList1 = Helper.ContiguousSubList(arrayList, sum);

            //for (int i = 0; i < arrayList1.Count; i++)
            //{
            //    Console.Write($"{arrayList1[i]} ");
            //}
            #endregion



            #region Q11

            //Queue<int> queueInt = new Queue<int>(5);
            //queueInt.Enqueue(1);
            //queueInt.Enqueue(2);
            //queueInt.Enqueue(3);
            //queueInt.Enqueue(4);
            //queueInt.Enqueue(5);

            //int k = 3;
            //Helper.ReverseKELement<int>(queueInt, k);

            #endregion
        }
    }
}
