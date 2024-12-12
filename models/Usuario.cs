namespace TodoAPI.models
{
    public class Usuario
    {
        public int Id { get; set; }
        public  required string Name { get; set; }
        public required string Email { get; set; }
        public required string password { get; set; }
    }
}