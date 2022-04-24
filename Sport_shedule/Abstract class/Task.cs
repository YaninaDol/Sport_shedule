using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_shedule
{
   abstract class Task
    {
        protected string Taskname { get; set; }
        protected int podhod;
        protected int povtor;

        protected Task(string taskname, int podhod, int povtor)
        {
            Taskname = taskname;
            this.podhod = podhod;
            this.povtor = povtor;
        }

        public override string ToString()
        {
            return $"{Taskname} : {podhod} подхода, {povtor} повторений ";
        }
        
    }
}
