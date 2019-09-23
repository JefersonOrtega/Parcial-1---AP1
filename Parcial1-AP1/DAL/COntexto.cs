using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.DAL
{
    class Contexto : DbContext
    {

        public DbSet<> MyProperty { get; set; }
        public Contexto() : base("ConStr")
        {

        }

    }
}
