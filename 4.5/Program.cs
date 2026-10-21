using System; 

namespace uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            int heltal = Convert.ToInt32(Console.ReadLine());

            string nyttTal = "";

            for (int i=0; i < heltal.ToString().Length; i++)
            {
                string tecken = heltal.ToString();
                int siffra = int.Parse(tecken[i].ToString());

                siffra++;

                if (siffra == 10)
                {
                    siffra = 0;
                }

                nyttTal += siffra.ToString();
            }

            Console.WriteLine(nyttTal);
        }
    }
}

