namespace CSSE375HW2
{
	class HtmlStatement: Statement
	{
		public override string HeaderString(Customer aCustomer)
		{
			return "<h1>Rentals for <em>" + aCustomer.GetName() + "</em></h1></p>\n";
		}

		public override string SingleRentalString(Rental aRental)
		{
			return aRental.GetMovie().GetTitle() + ": " + aRental.GetCharge() + "<br />\n";
		}

		public override string FooterString(Customer aCustomer)
		{
			return "<p>You owe <em>" + aCustomer.GetTotalCharge() + "</em></p>\nOn this rental you earned <em>" +
			       aCustomer.GetTotalFrequentRenterPoints() + "</em> frequent renter points</p>";
		}
	}
}
