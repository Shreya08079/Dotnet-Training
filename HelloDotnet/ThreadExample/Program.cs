using System;
namespace HelloDotnet{
    public class Program{

        public static async Task<string> FetchDataAsync(string url){
            using(HttpClient client = new HttpClient()){
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
        // public static void Main(string[] args){
        //     for(int i =0; i<100 ; i+=2){
        //         Console.Write(i + " ");
        //     }
        //     Thread.Sleep(3000);

        //     for(int i = 1;i<100;i+=2){
        //          Console.WriteLine(i+ " ");
        //     }

            //ThreadStart threadStart = new ThreadStart(RunStep2);
            public static async Task AsyncMethod(){
                Console.WriteLine("Task Started");
                await.Task.Delay(3000);
                Console.WriteLine("Task completed after 3 seconds");
            }

            public async void CallMethod(){
                string result = await.FetchDataSync("https://jsonplaceholder.typicode.com/todos");
                Console.WriteLine(result);
                await AsyncMethod();
            }
            
        
            Console.ReadLine();
        }
    }
}