using System;

namespace jauns
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b =0;
            
            for( a =1; a < 10; a++)
            {
                for ( b = 0; b < 10; b++)
                {   
                    int sum = a +b;
                 Console.WriteLine($"{a}{b}, {a}+{b} = {sum}");
                    
                }
            }
            



          
        }
    }
}
