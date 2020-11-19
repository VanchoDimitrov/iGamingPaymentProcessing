namespace iGamingPaymentProcessing
{
    public interface ICustomer
    {
        int CustomerID { get; set; }
        string LastName { get; set; }
        string Name { get; set; }
    }
}