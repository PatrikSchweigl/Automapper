using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    class Context :DbContext
    {
        public DbSet<MitarbeiterEFImpl> Mitarbeiter { get; set; }
        public DbSet<MitarbeiterAllgemeinEFImpl> MitarbeiterAllgemein { get; set; }
        public DbSet<NationEFImpl> Nation { get; set; }
    }
}
