namespace api_avaliaae.Models
{
    public class AverageModel
    {
        public int Id { get; set; }
        public double? Average { get; set; }
        public int InstitutionId { get; set; }
        public InstitutionModel Institution { get; set; }
    }
}
