namespace Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CASE 1
            /* 
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); // Saknar ";" i slutet
            }
            else if(number < 3) // Inget mellan rum mellan else if
            {
                Console.WriteLine("Talet är mindre än tre");
            }
            */

            // CASE 2
            /* 
            
            for (int i = 1; i < 101; i++) // Vi måste skriva 101 eftersom i stannar innan den når 100
            {                             // Vi kan också skriva  for "i <= 100" så den når 100
                Console.WriteLine(i);
            }
            */

            // CASE 3
            /*  
            for (int i = 1; i <= 5; i++) // Saknar ++, det ska stå " i++ "
            {
                for (int j = 1; j <= i; j++) // Saknar ++, det ska stå " j++ "
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            */


            // CASE 4
            /*   
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(i); // Det ska stå "WriteLine" och vi måste placer värdet "i" inom Console.Writeline
                }

                Console.WriteLine();
                i++;
            }
            */

            // CASE 5

            /*
            int i = 1;

            switch (i)
            {
                case 1:
                    break; //Saknas ett break i case 1
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            */


            //CASE 6
            int i = 10;

            if (i == 5) // Det behöver stå "==" för den att ska jämnföra om "i" är större eller lika med
            {
                Console.WriteLine("i är 5");
            }


        }
    }
}

