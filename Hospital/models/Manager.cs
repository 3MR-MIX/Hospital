namespace Hospital.models
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Doctors> Doctors { get; set; }
    }
}
