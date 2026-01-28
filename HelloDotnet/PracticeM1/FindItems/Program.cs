using System;
namespace HelloDotnet{
    public static SortedDictionary<string,long> itemDetails = new SortedDictionary<string,long>();

    public SortedDictionary<string,long> FinditemDetails(long SoldCount){
        SortedDictionary<string,long>answer = new SortedDictionary<string, long>();
        foreach(var item in itemDetails){
            if(item.Value == SoldCount){
                answer.Add(item.Key, item.Value);
            }
        }
        return answer;
    }
    public List<string> FindMinAndMaxSoldItems(){
        var SortItemDetails = itemDetails.OrderBy(x=>x.Value);
        List<string>ans = new List<string>();
        var list = SortItemDetails.ToList();
        ans.Add(list[0].Key);
        ans.Add(list[list.Count-1].Key);
        return ans;
    }
    public Dictionary<string,long>SortByCount(){
        var SortItemDetails = itemDetails.OrderBy(x=>x.Value);
        return SortItemDetails.ToDictionary();
    }

    public static void Main(string[] args){
        itemDetails.Add("pencil" , 18);
        itemDetails.Add("pen", 20);
        itemDetails.Add("sanitizer", 12);

        Program pro = new Program();
        var dic = pro.SortByCount();
        var list = pro.FindMinAndMaxSoldItems();
        var sortDic = pro.FinditemDetails(12);

        Console.WriteLine("Dictionary");

        foreach(var item in dic){
            Console.WriteLine($"{item.Key} {item.Value}");
        }
        Console.WriteLine("List : ");
        foreach(var item in list){
            Console.WriteLine($"{item}");
        }

        foreach(var item in sortDic){
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }

}