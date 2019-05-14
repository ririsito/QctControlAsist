using QctControlAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QctControlAsistencia.Data
{
    public class Dbinitializer
    {
        public static void Initialize(QctControlAsistenciaContext context)
        {
            context.Database.EnsureCreated();

            //Busca si existen registros en eventos

            if (context.Eventos.Any())
            {
                return;
            }

            var eventos = new Eventos[]
            {
                new Eventos {Eventosid=1,IdEmpleado=712286,Fecha=DateTime.Now}
            };


        }
    }
}
