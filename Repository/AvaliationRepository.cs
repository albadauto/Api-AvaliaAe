using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;

namespace api_avaliaae.Repository
{
    public class AvaliationRepository : IAvaliationRepository
    {
        private readonly DatabaseContext _context;
        public AvaliationRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task<List<AvaliationModel>> getAllAvaliations()
        {
            var list = new List<AvaliationModel>();
            var result = (from a in _context.Avaliations
                          join i in _context.Institution
                          on a.InstitutionId equals i.Id
                          select new { a.Comment, a.Note, i.InstitutionName});
            foreach ( var i in result ) 
            {
                list.Add(new AvaliationModel()
                {
                    Comment = i.Comment,
                    Note = i.Note,
                    Institution = new InstitutionModel()
                    {
                        InstitutionName = i.InstitutionName,
                    }
                });
            }
            return Task.FromResult(list);
        }
    }
}
