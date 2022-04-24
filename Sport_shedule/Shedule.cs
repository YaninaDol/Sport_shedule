using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sport_shedule
{
    class Shedule
    {
        public Dictionary<string, List<Muscule>> sport_shedule;
        public List<Muscule> tmp { get; set; }
       
        public Shedule()
        {
            sport_shedule = new Dictionary<string, List<Muscule>>();
            tmp=new List<Muscule>();
        }

        public void AddToDic(string dayofweek)
        {
              List<Muscule> toadd = new List<Muscule>();
            toadd.AddRange(tmp);
       
            sport_shedule.Add(dayofweek, toadd);
            tmp.Clear();

        }

        public void AddMuscule(Muscule muscule, Task task)
        {
          
            muscule.Addtask(task);
            tmp.Add(muscule);
        }

        public void Show()
        {
            
            foreach(var item in sport_shedule)
            {
               
                Console.WriteLine($"{item.Key} \n");
                {
                    if (item.Value.Count != 0)
                    {  foreach (var i in item.Value)
                        {

                            {
                                Console.WriteLine(i.Show());
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine(" Тренировок нет ");
                    }

                }
            }


        }


        public void Writefail(string path)
        {

            foreach (var item in sport_shedule)
            {

                File.AppendAllText(path, $"{item.Key} \n"); 
                {
                    if (item.Value.Count != 0)
                    {
                        foreach (var i in item.Value)
                        {

                            {
                                string str = i.Show();
                                File.AppendAllText(path, str);
                            }

                        }
                    }
                    else
                    {
                        File.AppendAllText(path, " Тренировок нет \n");
                        
                    }

                }
            }


        }
    }
  
}
