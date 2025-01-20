namespace Innova.Core.Models
{
    public class StudentAttendSession
    {
        public int? StudentId { get; set; }//FK
        public int? SessionId { get; set; }//FK
        public float Engagement_And_Participation { get; set; }
        public string PrivateNote { get; set; }
        public float Learning_And_Comprehension { get; set; }
        public float Behavioral_And_SocialSkill { get; set; }
    }
}