namespace FirstApp.Models
{
    public class Person
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Location { get; set; } = String.Empty;
    }
    public class Police
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Location { get; set; } = String.Empty;
    }
    public class PersonPolice
    {
        public Person person { get; set; }
        public Police police { get; set; }
    }

}
