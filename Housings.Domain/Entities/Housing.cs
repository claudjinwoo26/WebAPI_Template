using System.Net.Sockets;

namespace Housings.Domain.Entities
{
    public class Housing
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Address? Address { get; set; }

        public List<Furnitures> Furnitures { get; set; } = new();
    }
}
