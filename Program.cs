namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            char[] ch = { 'a', 'b', 'c', 'd' };
            string[] strArr = { "one", "two", "three" };

           
            demo2(arr);
            //demo2(strArr);
            Console.ReadLine();
        }
        /* static void demo(int[] ele)
     {
         foreach (int a in ele)
         {
             Console.WriteLine(a);
         }
     }*/

        //static void demo1(char[] chArr)
        //{
        //    foreach (char val in chArr)
        //    {
        //        Console.WriteLine(val);
        //    }

        //}


        public static void demo2<T>(T [] val)
        {
            
            foreach (T ele in val)
            {
                Console.WriteLine(ele);
            }
        }

    }
}


