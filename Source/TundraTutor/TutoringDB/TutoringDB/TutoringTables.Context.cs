﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TutoringDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TutorDatabaseEntities : DbContext
    {
        public TutorDatabaseEntities()
            : base("name=TutorDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<BusyTime> BusyTimes { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FacultyCours> FacultyCourses { get; set; }
        public virtual DbSet<TuteeBusyTime> TuteeBusyTimes { get; set; }
        public virtual DbSet<Tutee> Tutees { get; set; }
        public virtual DbSet<TutorBusyTime> TutorBusyTimes { get; set; }
        public virtual DbSet<TutorConfirmationRequest> TutorConfirmationRequests { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }
        public virtual DbSet<TutorTuteeCourseAppointment> TutorTuteeCourseAppointments { get; set; }
        public virtual DbSet<CurrentUser> CurrentUsers { get; set; }
        public virtual DbSet<StartEnd> StartEnds { get; set; }
        public virtual DbSet<TutorTuteeNotification> TutorTuteeNotifications { get; set; }
    }
}
