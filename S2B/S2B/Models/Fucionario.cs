using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2B.Models
{
    class Fucionario
    {
        private static bd_projeto_S2bEntitiesLogin db = new bd_projeto_S2bEntitiesLogin();//Connecta ao banco

        public static bool Verificar(string login, string senha)
        {
            if (db.FUNCIONARIOs.Where(a => a.LOGIN.Contains(login) && a.SENHA.Contains(senha)).Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
