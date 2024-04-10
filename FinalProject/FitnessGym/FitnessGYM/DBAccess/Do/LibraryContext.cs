using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Do;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<ParticipantsInTheCourse> ParticipantsInTheCourses { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\c#\\FinalProject\\FitnessGym\\FitnessGYM\\DBAccess\\DB.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CodeCourse).HasName("PK__Courses__4E3DEA2EE8F11900");

            entity.Property(e => e.CodeCourse).ValueGeneratedNever();
            entity.Property(e => e.Day)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaxParticipants).HasColumnName("Max_participants");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.NameNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Name)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teachers_Courses");
        });

        modelBuilder.Entity<ParticipantsInTheCourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("participants_in_the_course");

            entity.Property(e => e.CodeParticipant).HasColumnName("Code_participant");
            entity.Property(e => e.CodeSchedule).HasColumnName("Code_schedule");

            entity.HasOne(d => d.CodeParticipantNavigation).WithMany()
                .HasForeignKey(d => d.CodeParticipant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_participants_in_the_courseSubscribers");

            entity.HasOne(d => d.CodeScheduleNavigation).WithMany()
                .HasForeignKey(d => d.CodeSchedule)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_participants_in_the_courseSchedule");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.CodeSchedule).HasName("PK__Schedule__52AE036FBFD473DD");

            entity.ToTable("Schedule");

            entity.Property(e => e.CodeSchedule)
                .ValueGeneratedNever()
                .HasColumnName("Code_schedule");
            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.CodeCourseNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.CodeCourse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Schedule_Courses");
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity.HasKey(e => e.SubscriberId).HasName("PK__Subscrib__7DFEB634647A61B1");

            entity.Property(e => e.SubscriberId)
                .ValueGeneratedNever()
                .HasColumnName("SubscriberID");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateOfSubscription).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subscriptionType");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.LessonName).HasName("PK__Teachers__08F413AACE654B0C");

            entity.Property(e => e.LessonName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TeachersId).HasColumnName("TeachersID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
