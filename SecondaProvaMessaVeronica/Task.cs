using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondaProvaMessaVeronica
{
    enum LivelloImportanza
    {
       Basso,
        Medio,
       Alto
    }
    class Task
    {
        private static int _ID;
        public int ID { get; }
        public string Descrizione { get; }
        public DateTime DataDiScadenza { get; }
        //public enum Livello { basso, medio, alto}
       public string Livello { get; }
        //public Dictionary<string, LivelloImportanza> _LivelloImportanza = new Dictionary<string,LivelloImportanza>();

        public Task(string descrizione, string livello)
        {
            
            Descrizione = descrizione;
            //DataDiScadenza = datadiscadenza;
            Livello =livello;
            ID = ++_ID;
        }
        public string DatiTask
        {
            get
            {
                return ID + " " + Descrizione + " " + DataDiScadenza + " " + Livello;
            }
        }

    }
}
