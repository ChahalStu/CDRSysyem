﻿namespace UKZNCDRS.Models
{
 

        public class Patient
        {
            public int PatientID { get; set; }
            public string PatientName { get; set; }
            public string PatientLastName { get; set; }
            public DateTime PatientDateOfBirth { get; set; } // Nullable DateTime
            public string PatientGender { get; set; }
            public string? PatientAddress { get; set; }
            public string? PostalCode { get; set; }
            public string PatientContactNumber { get; set; }
            public string PatientEmailAddress { get; set; }
            public string? PatientEmployerCellNo { get; set; }
            public string? PatientOccupation { get; set; }
            public string? CreatedBy { get; set; }
            public string? UpdatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string? SpouseName { get; set; }
            public string? SpouseContactNo { get; set; }
            public DateTime UpdatedDate { get; set; }
            public bool isActive { get; set; }
            public bool isPatientStudent { get; set; }
            public string? School { get; set; }
            public string? Grade { get; set; }
            public string? Teacher { get; set; }
            public string? SchoolContactNo { get; set; }
            public string? FatherDetails { get; set; }
            public string? FathersName { get; set; }
            public string? FatherOccupation { get; set; }
            public string? FatherAddress { get; set; }
            public string? FatherWorkPhone { get; set; }
            public string? FatherCellPhone { get; set; }
            public string? FatherEmail { get; set; }
            public string? MotherDetails { get; set; }
            public string? MotherName { get; set; }
            public string? MotherOccupation { get; set; }
            public string? MotherAddress { get; set; }
            public string? MotherCellphone { get; set; }
            public string? MotherWorkPhone { get; set; }
            public string? MotherEmail { get; set; }
            public string? OtherDoctorDetails { get; set; }
            public string? FamilyDoctorName { get; set; }
            public string? FamilyDoctorInstitution { get; set; }
            public string? FamilyDoctorContactNo { get; set; }
            public string? PsychologistName { get; set; }
            public string? PsychologistInstitution { get; set; }
            public string? PsychologistContactNo { get; set; }
            public string? SocialWorkerName { get; set; }
            public string? SocialWorkerInstitution { get; set; }
            public string? SocialWorkerContactNo { get; set; }
            public string? OccupationalTherapist { get; set; }
            public string? OccupationalTherapistName { get; set; }
            public string? OccupationalTherapistInstitution { get; set; }
            public string? OccupationalTherapistContactNo { get; set; }
        }

    }

