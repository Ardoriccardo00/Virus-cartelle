using System;
using System.Diagnostics;
using System.IO;

namespace Programma
{
    class Program
    {
        public static string Radice;
        public static string percorsoDesktop;
        public static string percorsoDownloads;
        public static string percorsoDocumenti;
        public static string percorsoMusica;
        public static string percorsoImmagini;
        public static string percorsoVideo;

        static void Main(string[] args)
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("Benvenuto nel mio virus elimina cartelle! #");
            Console.WriteLine("###########################################");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("#################");
            Console.WriteLine("Cosa vuoi fare? #");
            Console.WriteLine("#################");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("####################################");
            Console.WriteLine("1: Eliminare i file nelle cartelle #");
            Console.WriteLine("Altro tasto: Esci                  #");
            Console.WriteLine("####################################");


            string line = Console.ReadLine();
            int Scelta = int.Parse(line);

            if (Scelta == 1) {

                Console.WriteLine("");
                Console.WriteLine("Stai usando una versione di Windows in italiano o in inglese?");
                Console.WriteLine("1: italiano");
                Console.WriteLine("2: inglese");

                string lineLingua = Console.ReadLine();
                int SceltaLingua = int.Parse(lineLingua);

                if (SceltaLingua == 1)
                {
                    Radice = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                    percorsoDesktop = Radice + "/Desktop";
                    percorsoDocumenti = Radice + "/Documenti";
                    percorsoImmagini = Radice + "/Immagini";
                    percorsoMusica = Radice + "/Musica";
                    percorsoDownloads = Radice + "/Downloads";
                    percorsoVideo = Radice + "/Video";
                }

                else if (SceltaLingua == 2)
                {
                    Radice = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                    percorsoDesktop = Radice + "/Desktop";
                    percorsoDocumenti = Radice + "/Documents";
                    percorsoImmagini = Radice + "/Pictures";
                    percorsoMusica = Radice + "/Music";
                    percorsoDownloads = Radice + "/Downloads";
                    percorsoVideo = Radice + "/Videos";
                }

                Console.WriteLine(Radice);
                Console.WriteLine(percorsoDesktop);
                Console.WriteLine(percorsoDocumenti);
                Console.WriteLine(percorsoImmagini);
                Console.WriteLine(percorsoMusica);
                Console.WriteLine(percorsoDownloads);
                Console.WriteLine(percorsoVideo);
                Console.WriteLine("");
                Console.WriteLine("Procedo all'eliminazione? Questa azione non sarà reversibile e i file non si troveranno nemmeno nel cestino");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Premi 1 per accettare oppure un altro tasto per annullare");

                string line2 = Console.ReadLine();
                int Scelta2 = int.Parse(line);

                if (Scelta2 == 1)
                {
                    //Directory.Delete(percorsoDesktop, true);
                    //Directory.Delete(percorsoDocumenti, true);
                    //Directory.Delete(percorsoImmagini, true);
                    //Directory.Delete(percorsoMusica, true);
                    //Directory.Delete(percorsoDownloads, true);
                    //Directory.Delete(percorsoVideo, true);
                }

                else {
                    Console.WriteLine("Premi un tasto per chiudere");
                    Console.ReadLine();
                }

            }

            else {
                Console.WriteLine("Premi un tasto per chiudere");
                Console.ReadLine();
            }
        }
    }
}
