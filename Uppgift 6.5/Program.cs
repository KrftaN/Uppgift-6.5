namespace Uppgift_6._5
{
    class Program
    {
        static int Längst(int tal1, int tal2)
        {
            int LängdTal1 = Convert.ToString(tal1).Length;
            int LängdTal2 = Convert.ToString(tal2).Length;


            if (LängdTal2 > LängdTal1)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
        }
        static string Längst(string sträng1, string sträng2)
        {

            int längdStr1 = sträng1.Length;
            int längdStr2 = sträng2.Length;

            if (längdStr2 > längdStr1)
            {
                return sträng2;
            }
            else
            {
                return sträng1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Längst(1, 53123));

        }
    }
}