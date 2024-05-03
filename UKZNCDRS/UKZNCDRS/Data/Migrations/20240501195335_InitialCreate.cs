using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKZNCDRS.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientEmployerCellNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    isPatientStudent = table.Column<bool>(type: "bit", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherWorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherCellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherCellphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherWorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDoctorDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyDoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyDoctorInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyDoctorContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PsychologistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PsychologistInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PsychologistContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialWorkerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialWorkerInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialWorkerContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupationalTherapist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupationalTherapistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupationalTherapistInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupationalTherapistContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
