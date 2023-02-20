namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("input traffic lights color");
            //string s=Console.ReadLine();
            //TrafficLight(s);


            DayTime now = DayTime.Evening;
            PrintMessage(now);                   // Добрый вечер
            PrintMessage(DayTime.Afternoon);    // Добрый день
            PrintMessage(DayTime.Night);        // Доброй ночи

            void PrintMessage(DayTime dayTime)
            {
                switch (dayTime)
                {
                    case DayTime.Morning:
                        Console.WriteLine("Доброе утро");
                        break;
                    case DayTime.Afternoon:
                        Console.WriteLine("Добрый день");
                        break;
                    case DayTime.Evening:
                        Console.WriteLine("Добрый вечер");
                        break;
                    case DayTime.Night:
                        Console.WriteLine("Доброй ночи");
                        break;
                }
            }
        }




        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public static void TrafficLight(string s)
        {
            switch (s)
            {
                case "red":

                    {
                        Console.WriteLine("stop!");
                        break;
                    }
                case "orange":
                    {
                        Console.WriteLine("to wait");
                        break;
                    }
                case "green":
                    {
                        Console.WriteLine("start");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("input true color!");
                        break;
                    }
            }
        }
    }
}