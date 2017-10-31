using System.ComponentModel.DataAnnotations;

namespace Biztek.Paisadeal.App.Models
{
    public enum LoanType
    {
        Business = 1,
        Personal = 2
    }

    public enum EmployeeType
    {
        Employee = 1,
        Employer = 2
    }

    public enum JobType
    {
        Employee = 1,
        Business = 2
    }


    public class TypeOFLoanViewModel
    {
        public TypeOFLoanViewModel()
        {

        }

        public TypeOFLoanViewModel(string businessType) {
            this.SelectedLoanType = businessType;
        }
        
        [Required(ErrorMessage = "select one type of loan")]
        [Display(Name = "Type Of Loan")]
        public LoanType LoanType { get; set; }

        [Required(ErrorMessage = "select one type of Employee")]
        [Display(Name = "Employbility")]
        public EmployeeType EmployeeType { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "Company Phone Number")]
        [Phone]
        public string CompanyPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Net Salary")]
        public int NetSalary { get; set; }

        [Required]
        [Display(Name = "Annual Salary")]
        public int AnnualSalary { get; set; }

        [Required]
        [Display(Name = "Form 16 ID")]
        public string Form16 { get; set; }

        [Display(Name = "Type Of Company")]
        public string TypeOfCompany { get; set; }

        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "PinCode")]
        public int PinCode { get; set; }

        public string SelectedLoanType { get; set; }
        public string SelectedEmployeeType { get; set; }

    }

    public class CreditInformationViewModel
    {
        [Required(ErrorMessage = "select one type of loan")]
        [Display(Name = "Type Of Job")]
        public EmployeeType EmployeeType { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Company Bank Account Info")]
        public string CompanyBankAccount { get; set; }

        [Display(Name = "Type Of Company")]
        public string TypeOfCompany { get; set; }

        [Required]
        [Display(Name = "Aadhar Card Number")]
        public string AadharCardNumber { get; set; }

        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "IT Number")]
        public string ITNumber { get; set; }

        [Display(Name = "Profficient Type")]
        public string ProfficientType { get; set; }

        [Required]
        [Display(Name = "Cibil Information")]
        public string CibilInformation { get; set; }

    }


}