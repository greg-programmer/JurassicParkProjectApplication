namespace webapi.Models
{
    public class Dinosaur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Food> Foods { get; set; }
        public int SpacyId { get; set; }
        public Spacy Spacy { get; set; }
    }   
}
