namespace invoicing.Models
{
    public record InvoicingViewModel
    {
        public string FullName { get; set; }

        public decimal HoursValue { get; set; }

        public int Antiquity { get; set; }

        public int HoursWorked { get; set; }

    }
}   
