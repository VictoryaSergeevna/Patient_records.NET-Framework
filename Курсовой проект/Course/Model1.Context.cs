﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Course
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Registration_patientsEntities2 : DbContext
    {
        public Registration_patientsEntities2()
            : base("name=Registration_patientsEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Analyzes> Analyzes { get; set; }
        public virtual DbSet<Archives> Archives { get; set; }
        public virtual DbSet<Card_Patients> Card_Patients { get; set; }
        public virtual DbSet<Procedures> Procedures { get; set; }
        public virtual DbSet<Ref_Analyzes> Ref_Analyzes { get; set; }
        public virtual DbSet<Ref_Procedures> Ref_Procedures { get; set; }
        public virtual DbSet<Result_Analyzes> Result_Analyzes { get; set; }
        public virtual DbSet<Sick_leaves> Sick_leaves { get; set; }
        public virtual DbSet<Therapists> Therapists { get; set; }
    }
}
