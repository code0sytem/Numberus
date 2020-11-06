using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace MidSection
{
    public class MidInicioDeSesion
    {
        public string IniciarSesion(string user, string pass)
        {
            if (user.Length <= 30 && pass.Length <= 30)
            {
                byte[] claveByte = Encoding.Unicode.GetBytes(pass.Trim());
                string clavetxt = BitConverter.ToString(claveByte).Replace("-", string.Empty);

                return clavetxt;
            }
            else
            {
                
                return "";
            }
        }
    }
}
