using System.Diagnostics;

class FarmGmod
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lancement du script...");

        Console.WriteLine("\n Combien de fois souhaitez-vous lancer Gmod ?");
        int input = Convert.ToInt32(Console.ReadLine()) + 1;

        for(int i = 1; i < input; i++)
        {
            Console.WriteLine("Lancement de Gmod pour la " + i + " fois.");

            Process gmod = Process.Start(new ProcessStartInfo("C:/Program Files (x86)/Steam/steamapps/common/GarrysMod/hl2.exe"));
            Console.WriteLine("Gmod lancé ! Attente de 10 secondes.");
            Thread.Sleep(10000);
            Console.WriteLine("Reprise.");
            gmod.Kill();
            Console.WriteLine("Gmod a été fermé !");
            Console.WriteLine("Attente de 10 secondes.");
            Thread.Sleep(10000);
            Console.WriteLine("Reprise...");
        }

        Console.WriteLine("Finis !");
    }
};
