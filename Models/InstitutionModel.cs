namespace api_avaliaae.Models
{
    public class InstitutionModel
    {
        public int Id { get; set; }

        public string InstitutionName { get; set; }
        public string Cnpj { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string District { get; set; }    
        public string Number { get; set; }
        public string Cep { get; set; }
        public string Description { get; set; }
        public InstitutionTypeModel InstitutionType { get; set; }
        public int InstitutionTypeId { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerCpf { get; set; }
    }
}
