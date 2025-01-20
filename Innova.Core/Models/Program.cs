namespace Innova.Core.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Package> Packages { get; set; }
        public ICollection<StudentProgram> StudentsPrograms { get; set; }
        public ICollection<FinalProjectFile> FinalProjectFiles { get; set; }
    }
}