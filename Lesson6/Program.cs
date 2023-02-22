using System.Security.Cryptography.X509Certificates;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel arajin tivy");
            string s1 = Console.ReadLine();
            int x= N1(ref s1);
            Console.WriteLine("nermucel nshann");
            char y =char.Parse(Console.ReadLine());

            Console.WriteLine("nermucel ekrord tivn");
            string s2 = Console.ReadLine(); 
            int z = N1(ref s2);
            Calc(x,y,z);
        }
        public static int N1(ref string s1)
        {
            
            int x;

            bool isParsable = Int32.TryParse(s1, out x);
            do
            {
                if (isParsable)
                {
                    x=int.Parse(s1);
                    break;

                }
                else
                {
                    Console.WriteLine("Could not be parsed.");
                    s1 = Console.ReadLine();
                    N1(ref s1);
                   
                }
            }while(isParsable);
                    x=int.Parse(s1);

            return x;
        }


        public static void Calc(int x,char y,int z)
        {
            switch (y)
            {
                case '+':
                    {
                        Console.WriteLine(x+z);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(x-z);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(x*z);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(x/z);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("nermucel jisht sinvol");
                        break;
                    }    

            }
        }
    }
}