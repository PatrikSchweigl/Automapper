using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    public interface Nation
    {
        string Bezeichnung { get; set; }
    }

    public interface Mitarbeiter
    {
        string Name { get; set; }
        Nation Nation { get; set; }
        MitarbeiterAllgemein MitarbeiterAllgemein { get; set; }
    }

    public interface MitarbeiterAllgemein
    {
        string Nummer { get; set; }
    }
}
