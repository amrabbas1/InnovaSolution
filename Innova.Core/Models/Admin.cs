namespace Innova.Core.Models
{
    public class Admin : User
    {
        public ICollection<Instructor> Instructors { get; set; }

    }
}