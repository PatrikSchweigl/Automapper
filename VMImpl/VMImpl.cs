using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    public class NationVMImpl : Nation
    {
        public string Bezeichnung { get; set; }
    }

    public class MitarbeiterVMImpl : Mitarbeiter
    {
        public string Name { get; set; }
        public  Nation Nation { get; set; }
        public MitarbeiterAllgemein MitarbeiterAllgemein { get; set; }
    }

    public class MitarbeiterAllgemeinVMImpl : MitarbeiterAllgemein
    {
        public string Nummer { get; set; }
    }
}
