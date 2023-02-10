using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;

namespace api_avaliaae.Repository
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly DatabaseContext _context;
        public InstitutionRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<InstitutionModel>> getAllInstitutionsWithType()
        {
            List<InstitutionModel> inst = new List<InstitutionModel>();
            var result = (from i in _context.Institution
                          join t in _context.InstitutionType on i.InstitutionTypeId equals t.Id
                          select new { i.InstitutionName, t.Name });
            foreach (var i in result)
            {
                inst.Add(new InstitutionModel()
                {
                    InstitutionName = i.InstitutionName,
                    InstitutionType = new InstitutionTypeModel()
                    {
                        Name = i.Name
                    }
                }); ;
            }

            return await Task.FromResult(inst);
        }
    }
}
