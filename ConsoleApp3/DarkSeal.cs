using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
   
    public class DarkSeal : Item
    {
       
        public DarkSeal()
        {
            
          name = "Dark Seal";
         
          price = 350;
            
          AddStat(Stat.AP, 15);
        }
    }
}