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
                          select new { Institution = i, t.Name, idType = t.Id});
            foreach (var i in result)
            {
                inst.Add(new InstitutionModel()
                {
                    InstitutionName = i.Institution.InstitutionName,
                    Cnpj = i.Institution.Cnpj,
                    Phone = i.Institution.Phone,
                    Email = i.Institution.Email,
                    Address = i.Institution.Address, 
                    District = i.Institution.District,
                    Number = i.Institution.Number,  
                    Cep = i.Institution.Cep,
                    Description = i.Institution.Description,
                    InstitutionType = new InstitutionTypeModel()
                    {
                        Id = i.idType,
                        Name = i.Name
                    }
                }); ;
            }

            return await Task.FromResult(inst);
        }

        public Task<InstitutionModel> GetInstitutionById(int id)
        {
            var result = _context.Institution.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(result);
        }
    }
}
