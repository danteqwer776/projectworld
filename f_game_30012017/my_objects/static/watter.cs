using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_game_30012017
{
   public class watter:Static_obj
    {

      public  watter(string color)
        {
            color_in_map = color;

            AnyDinamobject = false;//вода не может содержать 'динам' обьектов.
            seat_obj = null;       //
        }


    }
}
