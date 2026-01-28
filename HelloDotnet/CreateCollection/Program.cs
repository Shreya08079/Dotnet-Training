using System;

namespace HelloDotnet{
    public class Collection{
        public static void Main(string[] args){
            MyGlobalType<UGStudent> myGlobalType = new MyGlobalType<UGStudent>();

            UGStudent obj = new UGStudent;
            string result = MyGlobalType.GetDataType(obj);

            Console.WriteLine(result);

            Console.ReadLine(); 
        }
    }

    public class MyGlobalType<T>
}