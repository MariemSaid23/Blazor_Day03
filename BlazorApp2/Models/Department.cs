namespace BlazorApp2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Deptname { get; set; }
        public string? Departmentlocation { get; set; }
        public int Studentnumbers { get; set; }

        public List<string> Studentname { get; set; } = new List<string>();
    }
}
