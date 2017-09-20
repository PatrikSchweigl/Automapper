using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Data.Entity;

namespace VMImpl
{
    class Program
    {   
        public static void Main(string [] args)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MitarbeiterEFImpl, MitarbeiterVMImpl>();
                cfg.CreateMap<MitarbeiterVMImpl, MitarbeiterEFImpl>();
                cfg.CreateMap<List<MitarbeiterEFImpl>, List<Mitarbeiter>>();
                cfg.CreateMap<List<MitarbeiterEFImpl>, List<MitarbeiterVMImpl>>();
            });

            Mitarbeiter mitarb = new MitarbeiterEFImpl
            {
                Name = "Hans",
                Nation = new NationEFImpl { Bezeichnung = "Austria" },
                MitarbeiterAllgemein = new MitarbeiterAllgemeinEFImpl { Nummer = "1234" }
            };
            Mitarbeiter mitarb2 = new MitarbeiterEFImpl
            {
                Name = "Michael",
                Nation = new NationEFImpl { Bezeichnung = "Austria" },
                MitarbeiterAllgemein = new MitarbeiterAllgemeinEFImpl { Nummer = "1235" }
            };
            List<MitarbeiterEFImpl> list = new List<MitarbeiterEFImpl>
            {
                mitarb as MitarbeiterEFImpl,
                mitarb2 as MitarbeiterEFImpl
            };
            Mitarbeiter mapper = Mapper.Map<MitarbeiterVMImpl>(mitarb);
            ICollection<Mitarbeiter> mapper2 = Mapper.Map<ICollection<Mitarbeiter>>(list); //replace EFWrapCollection?
            ICollection<MitarbeiterVMImpl> mapper3 = Mapper.Map<ICollection<MitarbeiterVMImpl>>(list);


            //repo tests
            DbContext context = new Context();
            
            //context.Entry(mitarb).State = EntityState.Added;
            //context.SaveChanges();
            Repository repo = new RepositoryEF(context);
            ICollection<Mitarbeiter> m = repo.GetAll<Mitarbeiter>();    //works
            Console.WriteLine(m.Count);
        }
    }
}
