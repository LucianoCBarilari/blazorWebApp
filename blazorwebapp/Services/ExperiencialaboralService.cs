

using blazorwebapp.Data;
using Microsoft.EntityFrameworkCore;

namespace blazorwebapp.Services
{
    public class ExperiencialaboralService
    {
        private  readonly IDbContextFactory<Portweb> _dbContextFactory;

        public ExperiencialaboralService(IDbContextFactory<Portweb> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddExperiencia(ExperienciaLaboralModel experiencia) 
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.ExperienciaLaboralModel.Add(experiencia);
            context.SaveChanges();
        }

        public List<ExperienciaLaboralModel>  GetExperiencia()
        {
            using var context = _dbContextFactory.CreateDbContext();
            List<ExperienciaLaboralModel> listExp = context.ExperienciaLaboralModel.ToList();
            return listExp;
        }

    }
}
