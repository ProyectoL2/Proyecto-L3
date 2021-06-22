using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
    public class SeguridadBl
    {
      public  bool Automatizar(string usuario, string contrasena)
        {
            if ( usuario == "gladys" && contrasena == "gladys15")
            {
                return true;
            }
            else
            {
                if (usuario == "Henry" && contrasena == "Henry19")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
