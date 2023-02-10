namespace api_avaliaae.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string? photo_uri { get; set; }
        public bool? Is_allowed { get; set; }

        public string District { get; set; }

        public int Number { get; set; }
        public string Cep { get; set; }
        public string Address { get; set; }

        public int UserTypeId { get; set; }

    }
}
