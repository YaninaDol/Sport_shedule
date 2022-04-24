using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_shedule
{
    class Biceps:Muscule
    {
        public Biceps() : base(" Бицепс ")
        {
        }

        public override void Addtask(Task task)

        {
            this.tasks.Add(task);

        }
        public override string Show()
        {
            StringBuilder str = new StringBuilder();

            str.Append(" Группа мышц : " + this.Muscula + "\n");

            foreach (var Task in tasks)
            {
                str.Append(Task.ToString());
            }

            return str.ToString();
        }

    }
}
