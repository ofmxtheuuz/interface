using System.Globalization;

namespace LocadoraWOUT.Entities
{
    class Invoice
    {
        public double basicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            Tax = tax;
        }

        public double totalPayment
        {
            get { return basicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment: "
            + basicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal Payment: "
            + totalPayment.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
