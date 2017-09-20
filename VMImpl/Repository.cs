using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMImpl
{
    public interface Repository
    {
        ICollection<TModel> GetAll<TModel>();
    }

    public class RepositoryEF : Repository
    {
        private DbContext context = null;

        public RepositoryEF(DbContext context)
        {
            this.context = context;
        }

        public ICollection<TModel> GetAll<TModel>()
        {
            var implType = Util.typeMapperEF[typeof(TModel)];
            return AutoMapper.Mapper.Map<ICollection<TModel>>(context.Set(implType));
        }
    }

    public class RepositoryVM : Repository
    {
        Repository repo = null;
        public ICollection<TModel> GetAll<TModel>()
        {
            var implType = Util.typeMapperEFVM[typeof(TModel)];
            var temp = repo.GetAll<TModel>();
            var type = temp.GetType().GetNestedTypes().First();
            var resultType = implType[type];
            //result has to be mapped from EFImplType to VMImpltype and then return the interfacetype
            return temp;

        }
    }
}
