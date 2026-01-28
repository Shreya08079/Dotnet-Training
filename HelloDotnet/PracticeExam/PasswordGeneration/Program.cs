using System;
public class TechXamPassword{
    public static void Main(){
        Console.WriteLine("Enter the username:");
        string username = Console.ReadLine();

        if(username.Length !=8){
            Console.WriteLine(username + "is an invalid username");
            return;
        }

        for(int charIndex = 0; charIndex < 4; charIndex++){
            if(!(username[charIndex]>='A' && username[charIndex] <='Z')){
                Console.WriteLine(username + "is an invalid username");
                return;
            }
        }

        if(username[4] !='@'){
            Console.WriteLine(username + "is an invalid username");
            return;
        }

        int courseId = 0;
        for(int digitIndex = 5; digitIndex < 8; digitIndex++){
            if(!(username[digitIndex] >='0' && username[digitIndex]<='9')){
                Console.WriteLine(username + "is an invalid username");
                return;
            }

            courseId = courseId * 10 + (username[digitIndex] - '0');
        }

        if (courseId < 101 || courseId > 115)
        {
            Console.WriteLine(username + " is an invalid username");
            return;
        }

        int asciiSum = 0;
        for(int letterIndex = 0; letterIndex < 4; letterIndex++){
            char lower = char.ToLower(username[letterIndex]);
            asciiSum += lower;

        }

        int lastTwoDigits = courseId % 100;

        Console.WriteLine("Password : TECH_" + asciiSum + lastTwoDigits);
    }
}