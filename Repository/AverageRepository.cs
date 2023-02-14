using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;

namespace api_avaliaae.Repository
{
    public class AverageRepository : IAverageRepository
    {

        private readonly DatabaseContext _context;
        public AverageRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task<List<AverageModel>> GetAllAverages()
        {
            var result = _context.Average.ToList();
            return Task.FromResult(result);
        }

        public Task<List<AverageModel>> GetAveragesByInstitution()
        {
            List<AverageModel> model = new List<AverageModel>();
            var result = (from a in _context.Average
                          join i in _context.Institution
                          on a.InstitutionId equals i.Id
                          select new { i.InstitutionName, a.Average});
            foreach(var i in result)
            {
                model.Add(new AverageModel
                {
                    Average = i.Average,
                    Institution = new InstitutionModel()
                    {
                        InstitutionName = i.InstitutionName,
                    }
                });
            }

            return Task.FromResult(model);
        }

    }
}
