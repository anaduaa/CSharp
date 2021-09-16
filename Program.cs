using System;
using System.Linq;
namespace LinQCsharp
{
    class Program
    {
        static void Main(string[] args)
        { string numberofStrings; int NOS;int minNumb;
            numberofStrings = (Console.ReadLine());

            bool isnumber =int. TryParse(numberofStrings, out NOS);
            if(isnumber)
            {
                string []array = new string[NOS];
             for(int i = 0; i < NOS; i++)
                {
                    array[i] = Console.ReadLine();
                }
                string min;
                min = Console.ReadLine();
                bool isnum = int.TryParse(min, out minNumb);

                if (isnum)
                {


                    var filtered =
                        from val in array
                        where val.Length >= minNumb
                        select val;


                    foreach ( var item in filtered)
                    {
                        //The items of minimum 5 characters are :Item: string
                        Console.WriteLine($"The items of minimum {minNumb} characters are :");
                        Console.WriteLine($"Item: {item}");
                    }
                }
            }
           
        }
    }
}
