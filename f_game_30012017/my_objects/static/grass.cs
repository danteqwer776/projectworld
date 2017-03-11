using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace f_game_30012017
{
  public  class grass:Static_obj
    {

      

      public  grass(string color,Random M)//в конструкторе заполняется цвет обьекта ,а также есть ли у него динам обьект
        {
            color_in_map = color;
            seat_obj = null;

        
            int help=M.Next(0, 15);
            if (help != 0) { AnyDinamobject = false;}
            else AnyDinamobject = true;

           
            

        }
    }
}
