namespace CSSE375HW2
{
	class TextStatement: Statement
	{
		public override string HeaderString(Customer aCustomer)
		{
			return "Rental Record for " + aCustomer.GetName() + "\n";
		}

		public override string SingleRentalString(Rental aRental)
		{
			return "\t" + aRental.GetMovie().GetTitle() + "\t" + aRental.GetCharge() + "\n";
		}

		public override string FooterString(Customer aCustomer)
		{
			return "Amount owed is " + aCustomer.GetTotalCharge() + "\nYou earned " + aCustomer.GetTotalFrequentRenterPoints() +
			       " frequent renter points";
		}
	}
}
