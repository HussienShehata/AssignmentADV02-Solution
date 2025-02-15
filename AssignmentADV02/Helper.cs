using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02
{
    internal static class Helper
    {

        #region methods




        #region Q1


        public static void QueryToArray(int[] arr, int queryNumber)
        {
            int query;
            int counter = 0;
            for (int i = 0; i < queryNumber; i++)
            {
                Console.WriteLine("Enter {i+1} query : ");
                int.TryParse(Console.ReadLine(), out query);
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > query)
                        counter++;

                }
                Console.WriteLine($" {counter} numbers in the array is greater then {i + 1} query");
            }


        }
        #endregion

        #region Q2


        public static bool Palindrome(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                for (int j = arr.Length; j > arr.Length / 2; j--)
                {
                    if (arr[j] != arr[i])
                        return false;


                }
            }
            return true;
        }


        #endregion

        #region Q3


        public static void ReverseByStack(Queue<int> queue)
        {
            int[] arr = new int[queue.Count];
            queue.CopyTo(arr, 0);
            Stack<int> stack = new Stack<int>(queue.Count);


            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            foreach (int item in stack)
            {
                Console.Write($"{item} ");
            }
        }



        #endregion

        #region Q4

        //public static void ParenthesesCheck(Stack<string> stack)
        //{
        //    string[] arr = new string[stack.Count];
        //    arr = stack.ToArray();
        //    string queueElement;

        //    Console.WriteLine("array is :");
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        Console.Write(arr[i]);
        //    }
        //    Console.WriteLine("\n-------------------");

        //    Queue<string> queue = new Queue<string>(stack.Count);

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        queue.Enqueue(arr[i]);
        //    }
        //    Console.WriteLine("queue:");
        //    foreach (string item in queue)
        //    { Console.Write(item); }

        //    queueElement = queue.Dequeue();
        //    Console.Write(queueElement);

        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        for (int j = arr.Length - 1; j >= 0; j--)
        //        {
        //            queueElement = queue.Dequeue();
        //            if (queueElement != arr[i])
        //            {
        //                Console.WriteLine("\nNot balanced");

        //            }
        //            break;
        //        }
        //    }
        //    Console.WriteLine("Balanced");

        //}
        #endregion

        #region Q5

        public static T[] RemoveDuplication<T>(T[] arr)
        {

            T[]? tmp = new T[arr.Length];

            Array.Sort(arr);
            tmp[0] = arr[0];
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (!arr[i-1].Equals(arr[i ]))
                {
                    tmp[count++]=arr[i];
       
                } 
            }

            T[] newArr = new T[count];
            Array.Copy(tmp, newArr,count);

            return newArr;
        }


        #endregion

        #region Q6

        public static ArrayList RemoveOdd(ArrayList arrList)
        {
            if (arrList is not null && arrList.Count > 0)
            {
                for (int i = 0; i < arrList.Count; i++)
                {
                    if ((int)arrList[i] % 2 == 1)
                        arrList.RemoveAt(i);
                }
                arrList.TrimToSize();
                return arrList;
            }
            else
                return arrList;
        }

        #endregion


        #region Q8

        public  static void TargetInteger<T>(Stack<T> stack,T target)
        {
            T element;
            int loopLength= stack.Count;
            int count = 0;

            List<T> list = new List<T>(stack.Capacity);
            


            for (int i = 0; i < loopLength; i++)
            {

                stack.TryPop(out element);
                list.Add(element);
            }


       
            for (int i = 0; i < loopLength; i++)
            {
                count++;
                if (target.Equals(list[i]))
                {
                    Console.WriteLine($"Target is found successfully and the count = {count}");
                    break;
                }
                else if(i==loopLength-1 && !target.Equals(list[i]))
                    Console.WriteLine("Target was not found");

            }
           
        }

        #endregion


        #region Q9

        public static T[] IntersectionOfArrays<T>(T[] arr1, T[] arr2)
        {

            T[] arr3  ;
            if (arr1.Length.CompareTo(arr2.Length) < 0)
            {
                arr3 = new T[arr1.Length];
                for (int i = 0; i < arr1.Length; i++)
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (arr1[i].Equals(arr2[j]))

                            arr3[i] = arr1[i];
                    }
                return arr3;
            }
            else if (arr1.Length.CompareTo(arr2.Length) > 0)
            {
                arr3 = new T[arr2.Length];
                for (int i = 0; i < arr2.Length; i++)
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i].Equals(arr2[j]))

                            arr3[i] = arr1[i];
                    }
                return arr3;
            }
            else
            {
                arr3 = new T[arr1.Length];
                for (int i = 0; i < arr2.Length; i++)
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (arr1[i].Equals(arr2[j]))

                            arr3[i] = arr1[i];
                    }
                return arr3;
            }
                

        }

        #endregion

        #region Q10

        public static ArrayList ContiguousSubList(ArrayList arrList, int sum)
        {
            int result = 0;
            ArrayList arr = new ArrayList();
            for (int i = 0; i < arrList.Count; i++)
            {
                //result += 0;
                for (int j = i + 1; j < arrList.Count; j++)
                {
                    result += (int)arrList[j];
                    if (sum == result)
                    {
                        //arr.AddRange(i);
                        //arr.Add(arr[i]);
                        arr.Add(arr[j]);
                        return arr;
                    }
                    //else
                    //    arr.Add(-1);
                    //return arr;
                }
            }
            arr.Add(-1);
            return arr;

        }

        #endregion



        #region Q11

        public static void ReverseKELement<T>(Queue<T> queue, int k)
        {
            T element;
            List<T> list = new List<T>();
            for (int i = 0; i <k ;i++)
            {
                queue.TryDequeue(out element);
                list.Add(element);
            }

         
            list.Reverse();
 


            for (int i =3; i<5;i++)
            {
                queue.TryDequeue(out element);
                list.Add(element);
            }

            for (int i = 0; i < list.Count; i++)
            {
                queue.Enqueue(list[i]);
                //Console.Write($"{list[i]} ");
            }

            foreach (T item in queue)
            {
                Console.Write($"{item} ");
            }
        }

        #endregion

        #endregion
    }
}
