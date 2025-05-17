using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    public static class IdController
    {
       private static int? usuarioLogado = null;
       private static int? establishmentLogado = null;

       public static void SetIdUser(int userId)
        {
            usuarioLogado = userId;
        }

        public static int GetIdUser()
        {
            return usuarioLogado.Value;
        }
        public static void SetIdEstablishment(int establishmentId)
        {
            establishmentLogado = establishmentId;
        }

        public static int GetIdEstablishment()
        {
            return establishmentLogado.Value;
        }

        public static void LogOffUser()
        {
            usuarioLogado = null;
        }
        public static void LogOffEstablishment()
        {
            establishmentLogado = null;
        }

    }
}
