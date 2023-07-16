namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> adlar = new List<string>();
            adlar.Add("görkem");
            adlar.Add("furkan");
            adlar.Add("atıf");
            adlar.Add("yunus");
            adlar.Add("emre");
            adlar.Add("murat");
            adlar.Add("tekin");
            adlar.Add("mehmet");
            adlar.Add("barış");
            adlar.Add("erkan");

            Console.Write("Hangi ismi arıyorsunuz: ");

            string arananIsim = Console.ReadLine();

            for (int i = 0; i < adlar.Count; i++)
            {
                if (arananIsim == adlar[i])
                {
                    Console.WriteLine(arananIsim + " "+(i + 1) + ". sıradadır.");
                }
                
            }
        }
    }
}