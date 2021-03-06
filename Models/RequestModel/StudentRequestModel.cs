using System.ComponentModel.DataAnnotations;

namespace student_management_api.Models.RequestModel
{
    public class StudentRequestModel
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string fatherName { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string collegeName { get; set; }

        [Required]
        public string year { get; set; }

        [Required]
        public string department { get; set; }

        [Required]
        public int yearOfJoin { get; set; }

        public bool firstGraduate { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        [StringLength(10)]
        public string mobile { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string degree { get; set; }

        [Required]
        public string rollNo { get; set; }

        [Required]
        public string gender { get; set; }
    }
}
