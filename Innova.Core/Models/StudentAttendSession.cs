namespace Innova.Core.Models
{
    public class StudentAttendSession
    {
        public string? StudentId { get; set; }//FK
        public string? SessionId { get; set; }//FK
        public float Engagement_And_Participation { get; set; }
        public string PrivateNote { get; set; }
        public float Learning_And_Comprehension { get; set; }
        public float Behavioral_And_SocialSkill { get; set; }
    }
}