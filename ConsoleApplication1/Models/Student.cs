namespace ConsoleApplication1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double Katbi { get; set; }
        public double Amali { get; set; }
        public double Taklif { get; set; }
        public double EndScoore
        {
            get { return ((Katbi * 0.5) + (Amali * 0.3) + (Taklif * 0.2)) * 0.2; }
        }
    }
}