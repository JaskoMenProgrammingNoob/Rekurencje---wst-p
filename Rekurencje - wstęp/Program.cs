using System.Runtime.ExceptionServices;

class Program
{
    
    



  







    static void Main(string[] args)
    {
    int n = 15;
    double silnia = 1;



    for (int i = 1; i <= n; i++)
    {
        if (i == 1)
        {
            silnia = 1;
            Console.WriteLine($"{i}! = {silnia}");
        }
        else
        {
            silnia = silnia * i;
            Console.WriteLine($"{i}! = {silnia}");
        }
    }



}






}