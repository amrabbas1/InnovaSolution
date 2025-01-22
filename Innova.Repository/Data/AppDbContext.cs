using Innova.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Repository.Data
{
	public class AppDbContext : IdentityDbContext<User>
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<PromoCode>().HasKey(PK => PK.promoCode);

            builder.Entity<Achievement>().HasKey(PK => new { PK.StudentId, PK.PackageId});
            builder.Entity<CountryPackage>().HasKey(PK => new { PK.CountryId, PK.PackageId });
            builder.Entity<FinalProjectFile>().HasKey(PK => new { PK.StudentProgramStudentId, PK.StudentProgramProgramId });
            builder.Entity<OfferPackage>().HasKey(PK => new { PK.OfferId, PK.PackageId });
            builder.Entity<StudentAssignment>().HasKey(PK => new { PK.StudentId, PK.AssignmentId });
            builder.Entity<StudentAssignmentFiles>().HasKey(PK => new { PK.StudentAssignmentStudentId, PK.StudentAssignmentAssignmentId });
            builder.Entity<StudentAttendSession>().HasKey(PK => new { PK.StudentId, PK.SessionId });
            builder.Entity<StudentProgram>().HasKey(PK => new { PK.StudentId, PK.ProgramId });
            builder.Entity<StudentQuiz>().HasKey(PK => new { PK.StudentId, PK.QuizId });

            builder.Entity<FinalProjectFile>().Property(f => f.StudentProgramStudentId).HasColumnName("StudentId");
            builder.Entity<FinalProjectFile>().Property(f => f.StudentProgramProgramId).HasColumnName("ProgramId");

            builder.Entity<StudentAssignmentFiles>().Property(S => S.StudentAssignmentStudentId).HasColumnName("StudentId");
            builder.Entity<StudentAssignmentFiles>().Property(f => f.StudentAssignmentAssignmentId).HasColumnName("AssignmentId");

            base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<AssignmentFiles> AssignmentsFiles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryPackage> CountryPackages { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FinalProjectFile> FinalProjectFiles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupDate> GroupDates { get; set; }
        public DbSet<GroupFile> GroupFiles { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferPackage> OfferPackages { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageContent> PackageContents { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<PaymentInvoice> PaymentInvoices { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }
        public DbSet<StudentAssignmentFiles> StudentAssignmentFiles { get; set; }
        public DbSet<StudentAttendSession> StudentAttendSessions { get; set; }
        public DbSet<StudentProgram> StudentPrograms { get; set; }
        public DbSet<StudentQuiz> StudentQuizzes { get; set; }
    }

}
