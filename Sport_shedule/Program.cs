using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sport_shedule
{
    class Program
    {
        static void Main(string[] args)
        {

            Shedule my_sport_shedule = new Shedule();

            my_sport_shedule.AddMuscule(new Back(), new Tyaga_v_naklone(3, 9));
            my_sport_shedule.AddMuscule(new Chest(), new Razvod_ganteley(2, 15));
            my_sport_shedule.tmp[1].Addtask(new Zhim(4, 10));

            my_sport_shedule.AddToDic("Monday");
            my_sport_shedule.AddToDic("Thuesday");
            my_sport_shedule.AddToDic("Wednesday");

            my_sport_shedule.AddMuscule(new Foot(), new Prisedcs(3, 9));

            my_sport_shedule.AddMuscule(new Shouldres(), new Armeyskiy(3, 9));

            my_sport_shedule.AddMuscule(new Biceps(), new Tyaga(3, 9));
            
            my_sport_shedule.AddToDic("Thusday");
            my_sport_shedule.AddToDic("Friday");
            my_sport_shedule.AddToDic("Saturday");
            my_sport_shedule.AddToDic("Sunday");
               my_sport_shedule.Show();

          
            my_sport_shedule.Writefail(" My sport shedule ");
        }
    }
}
