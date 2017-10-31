namespace Biztek.Paisadeal.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeOFLoan")]
    public partial class TypeOFLoan
    {
        [Key]
        public string UserId { get; set; }

        [StringLength(25)]
        public string LoanType { get; set; }

        [StringLength(25)]
        public string EmployeeType { get; set; }

        [StringLength(250)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(15)]
        public string CompanyPhoneNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? AnnualSalary { get; set; }

        [StringLength(50)]
        public string Form16 { get; set; }

        [StringLength(150)]
        public string TypeOfCompany { get; set; }

        [StringLength(500)]
        public string CompanyAddress { get; set; }

        [StringLength(150)]
        public string State { get; set; }

        [StringLength(150)]
        public string City { get; set; }

        [StringLength(10)]
        public string PinCode { get; set; }
    }
}
