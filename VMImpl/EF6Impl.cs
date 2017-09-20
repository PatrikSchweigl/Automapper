using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    public class NationEFImpl : Nation
    {
        public Guid Id { get; set; }
        public string Bezeichnung { get; set; }
    }

    public class MitarbeiterEFImpl : Mitarbeiter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Nation Nation { get; set; }
        public MitarbeiterAllgemein MitarbeiterAllgemein { get; set; }
    }

    public class MitarbeiterAllgemeinEFImpl : MitarbeiterAllgemein
    {
        public Guid Id { get; set; }
        public string Nummer { get; set; }
    }
}
