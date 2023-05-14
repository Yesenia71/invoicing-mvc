namespace invoicing.Models
{
    public record InvoicingResultViewModel(
        string FullName,
        int Antiquity,
        decimal HoursValue,
        decimal TotalReceivable,
        decimal DescountTotal,
        decimal TotalPayable
    );
}
