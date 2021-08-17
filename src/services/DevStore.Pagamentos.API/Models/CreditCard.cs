namespace DevStore.Billing.API.Models
{
    public class CreditCard
    {
        public string Holder { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string SecurityCode { get; set; }

        protected CreditCard() { }

        public CreditCard(string holder, string cardNumber, string expirationMonth, string securityCode)
        {
            Holder = holder;
            CardNumber = cardNumber;
            ExpirationMonth = expirationMonth;
            SecurityCode = securityCode;
        }
    }
}