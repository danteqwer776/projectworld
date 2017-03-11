using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_game_30012017
{
    abstract public class Static_obj:Objject
    {
       public Dinam_obj seat_obj=null;//ссылка на динам обьект,"находящийся на обьекте трава"
        public  bool AnyDinamobject;
      public int x, y;//coordinats of element in datagridview's map
      public  string color_in_map = "";

      
        
    }
}
