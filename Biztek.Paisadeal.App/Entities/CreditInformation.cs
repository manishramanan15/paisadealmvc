namespace Biztek.Paisadeal.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditInformation")]
    public partial class CreditInformation
    {
        [Key]
        public string UserId { get; set; }

        [StringLength(50)]
        public string EmployeeType { get; set; }

        [StringLength(250)]
        public string CompanyName { get; set; }

        [StringLength(25)]
        public string CompanyBankAccount { get; set; }

        [StringLength(150)]
        public string TypeOfCompany { get; set; }

        [StringLength(25)]
        public string AadharCardNumber { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(25)]
        public string ITNumber { get; set; }

        [StringLength(50)]
        public string ProfficientType { get; set; }

        [StringLength(50)]
        public string CibilInformation { get; set; }
    }
}
