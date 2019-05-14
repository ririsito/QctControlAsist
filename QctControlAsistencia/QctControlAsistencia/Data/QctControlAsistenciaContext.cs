using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QctControlAsistencia.Models
{
    public class QctControlAsistenciaContext : DbContext
    {
        public QctControlAsistenciaContext (DbContextOptions<QctControlAsistenciaContext> options)
            : base(options)
        {
        }

        public DbSet<QctControlAsistencia.Models.Eventos> Eventos { get; set; }
    }
}
