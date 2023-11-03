using System.ComponentModel.DataAnnotations;

namespace projectdapper.Data.Models.Domain
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string? serialnumber  { get; set; }
        [Required]
        public string? employeename { get; set; }
        [Required]
        public string? gender { get; set; }
        [Required]
        public string? employeedob { get; set; }
        [Required]
        public string? department { get; set; }
        [Required]
        public string? designation { get; set; }
        [Required]
        public string? mobilenumber { get; set; }
        [Required]
        public string? emailid { get; set; }
        [Required]
        public string? panno { get; set; }
        [Required]
        public string? aadharno { get; set; }
        [Required]
        public string? dateofissue { get; set; }
        [Required]
        public string? expirydata { get; set; }
        [Required]
        public string? dataofapplication { get; set; }
        [Required]
        public string? dscno { get; set; }
        [Required]
        public string? status { get; set; }

    }
}
