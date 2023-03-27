namespace AnimalRoster6.Models
{
    public class Animal
    {
        public int Id { get; }
        private int nextId = 0;
        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        public Animal()
        {
            Id = nextId;
            nextId++;
        }

        public Animal(string name, string species, string description, string imgUrl): this()
        {
            Name = name;
            Species = species;
            Description = description;
            ImgUrl = imgUrl;
        }

        public override bool Equals(object? obj)
        {
            return obj is Animal animal &&
                   Id == animal.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            return Name;
        }

    }
}
