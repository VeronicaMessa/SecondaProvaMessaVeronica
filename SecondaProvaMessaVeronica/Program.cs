using System;
using System.IO;
namespace SecondaProvaMessaVeronica
{
    class Program
    {
        private static GestoreTask gestore = new GestoreTask();
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione Task ");

            do
            {
                Console.WriteLine("1. Visualizzare i task inseriti");
                Console.WriteLine("2. Aggiungere un nuovo task");
                Console.WriteLine("3. Eliminare un task");
                Console.WriteLine("4. Filtrare i task per importanza");
                Console.WriteLine("5. Salva");
                Console.WriteLine("0. Esci");

                // scegliere quale operazione effettuare 
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        VisualizzaTasks();
                        break;
                    case '2':
                        AggiungiTask();
                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                    case '5':
                        Salva();
                        break;
                    case '0':
                        // esci 
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;

                }
            } while (true);

        }

        private static void VisualizzaTasks()
        {
            Console.WriteLine();
            Console.WriteLine($"I Tasks presenti sono i seguenti: {gestore.TaskTotali}");
        }

        private static void AggiungiTask()
        {
            Task t;
            Console.WriteLine();
            Console.WriteLine("Immettere descrizione Task e livello di importanza: ");
            t = gestore.AggiungiTask(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine($"è stato aggiunto il task numero {t.ID} con descrizione {t.Descrizione} e di livello {t.Livello}");

        }
        private static void Salva()
        {// salvare su disco
            const string fileName = @"Tasks.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Close();
            }
        }
       
    }
}
