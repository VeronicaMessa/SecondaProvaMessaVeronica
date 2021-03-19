using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondaProvaMessaVeronica
{
    
    class GestoreTask
    {
        private Dictionary<int, Task> _Tasks = new Dictionary<int, Task>();


        public Task AggiungiTask(string descrizione, string livello)
        {
            Task t = new Task(descrizione, livello);
            _Tasks.Add(t.ID, t);
            return t;
        }
        public string TaskTotali
        {
            get
            {
                string s = "";
                foreach (Task t in _Tasks.Values)
                    s += "numero task: "+ t.ID+ " descrizione task: " + t.Descrizione +'\n';
                return s;
            }
        }
       
    }
}
