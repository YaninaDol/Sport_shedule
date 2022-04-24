using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_shedule
{
    abstract class Muscule
    {
        protected string Muscula { get; set; }
        protected List<Task> tasks;
       

        public Muscule(string muscula)
        {
            this.Muscula = muscula;
            tasks = new List<Task>();
        }

      
        public abstract void Addtask(Task task);
        public abstract string Show();

    }
}
