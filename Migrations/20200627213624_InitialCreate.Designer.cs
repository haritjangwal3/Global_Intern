﻿// <auto-generated />
using System;
using Global_Intern.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Global_Intern.Migrations
{
    [DbContext(typeof(GlobalDBContext))]
    [Migration("20200627213624_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Global_Intern.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Global_Intern.Models.AppliedInternship", b =>
                {
                    b.Property<int>("AppliedInternshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployerStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InternshipId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AppliedInternshipId");

                    b.HasIndex("InternshipId");

                    b.HasIndex("UserId");

                    b.ToTable("AppliedInternships");
                });

            modelBuilder.Entity("Global_Intern.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExperienceCompany")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExperienceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExperienceLocation")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExperienceStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExperienceStillWorking")
                        .HasColumnType("bit");

                    b.Property<string>("ExperienceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExperienceId");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Global_Intern.Models.InternStudent", b =>
                {
                    b.Property<int>("InternStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InternshipId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InternStudentId");

                    b.HasIndex("InternshipId");

                    b.HasIndex("UserId");

                    b.ToTable("InternStudents");
                });

            modelBuilder.Entity("Global_Intern.Models.Internship", b =>
                {
                    b.Property<int>("InternshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InternshipBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InternshipCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("InternshipDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternshipEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InternshipExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InternshipPaid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternshipTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternshipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InternshipUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InternshipVirtual")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InternshipId");

                    b.HasIndex("UserId");

                    b.ToTable("Internships");
                });

            modelBuilder.Entity("Global_Intern.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InternStudentId")
                        .HasColumnType("int");

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MessageFromUserId")
                        .HasColumnType("int");

                    b.Property<bool>("MessageRead")
                        .HasColumnType("bit");

                    b.Property<string>("MessageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MessageToUserId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("InternStudentId");

                    b.HasIndex("MessageFromUserId");

                    b.HasIndex("MessageToUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Global_Intern.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProfileAcademicRecord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileAmbitionSummnary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileCoverLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePersonalStatement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileRoleFit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Global_Intern.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldofStudy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificationSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("QualificationStillStudying")
                        .HasColumnType("bit");

                    b.Property<string>("QualificationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("QualificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("Global_Intern.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Global_Intern.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("UserCurrentCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("UserEmailVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserHomeCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLinks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Global_Intern.Models.UserCompany", b =>
                {
                    b.Property<int>("UserCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserCompanyInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCompanyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserCompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCompany");
                });

            modelBuilder.Entity("Global_Intern.Models.VisaStatus", b =>
                {
                    b.Property<int>("VisaStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VisaNumber")
                        .HasColumnType("int");

                    b.Property<string>("VisaType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisaStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("VisaStatus");
                });

            modelBuilder.Entity("Global_Intern.Models.AppliedInternship", b =>
                {
                    b.HasOne("Global_Intern.Models.Internship", "Internship")
                        .WithMany()
                        .HasForeignKey("InternshipId");

                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("appliedInternships")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Global_Intern.Models.Experience", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("experiences")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Global_Intern.Models.InternStudent", b =>
                {
                    b.HasOne("Global_Intern.Models.Internship", "Internship")
                        .WithMany()
                        .HasForeignKey("InternshipId");

                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("internStudents")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Global_Intern.Models.Internship", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Intern.Models.Message", b =>
                {
                    b.HasOne("Global_Intern.Models.InternStudent", "InternStudent")
                        .WithMany()
                        .HasForeignKey("InternStudentId");

                    b.HasOne("Global_Intern.Models.User", "MessageFrom")
                        .WithMany()
                        .HasForeignKey("MessageFromUserId");

                    b.HasOne("Global_Intern.Models.User", "MessageTo")
                        .WithMany()
                        .HasForeignKey("MessageToUserId");
                });

            modelBuilder.Entity("Global_Intern.Models.Profile", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Intern.Models.Qualification", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("qualifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Intern.Models.User", b =>
                {
                    b.HasOne("Global_Intern.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Intern.Models.UserCompany", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("userCompanies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Global_Intern.Models.VisaStatus", b =>
                {
                    b.HasOne("Global_Intern.Models.User", "User")
                        .WithMany("visaStatuses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
