using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    public class Util
    {
        public static Dictionary<Type, Type> typeMapperEF = new Dictionary<Type, Type>
        {
            { typeof(Mitarbeiter), typeof(MitarbeiterEFImpl) }
        };

        public static Dictionary<Type, Type> typeMapperVM = new Dictionary<Type, Type>
        {
            { typeof(Mitarbeiter), typeof(MitarbeiterVMImpl) }
        };

        public static Dictionary<Type, Dictionary<Type, Type>> typeMapperEFVM = new Dictionary<Type, Dictionary<Type, Type>>
        {
            {
                typeof(Mitarbeiter), new Dictionary<Type, Type>{ { typeof(MitarbeiterEFImpl), typeof(MitarbeiterVMImpl) } }
            },
        };


    }
}
