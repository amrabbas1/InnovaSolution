namespace Innova.Core.Models
{
    public class Program
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public List<Package> Packages { get; set; }
        public List<StudentProgram> StudentsPrograms { get; set; }
        public List<FinalProjectFile> FinalProjectFiles { get; set; }
    }
}