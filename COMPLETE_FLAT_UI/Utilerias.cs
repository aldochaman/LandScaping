using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
     class Utilerias
     {

          public StringBuilder  RegresaFechaQuerySQL(DateTime Pd_Fecha , Boolean Pb_IncluyeHHmmss)
          {

               StringBuilder Ls_Fecha = new StringBuilder();

                           
               string Ls_Prefijo = "'";
               string Ls_Posfijo = "'";
               string Ls_Separador = "/";

               Ls_Fecha.AppendFormat("{4}{1}{0}{2}{0}{3}", Ls_Separador, Pd_Fecha.Year, Pd_Fecha.Month.ToString().PadLeft(2,'0'), Pd_Fecha.Day.ToString().PadLeft(2, '0'), Ls_Prefijo);
          if (Pb_IncluyeHHmmss) 
             {
                    Ls_Fecha.AppendFormat(" {0}:{1}:{2}", Pd_Fecha.Hour.ToString().PadLeft(2,'0'), Pd_Fecha.Minute.ToString().PadLeft(2, '0'), Pd_Fecha.Second.ToString().PadLeft(2, '0'));
             }
               Ls_Fecha.AppendFormat("{0}", Ls_Posfijo);



          return Ls_Fecha;
     
          }

     }

}
