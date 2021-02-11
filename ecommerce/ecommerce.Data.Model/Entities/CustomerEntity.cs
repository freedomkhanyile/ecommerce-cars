namespace ecommerce.Data.Model.Entities
{
    public class CustomerEntity : UserEntity
    {
        public bool IsLegalEntity { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double AnnualIncome { get; set; }
    }
}