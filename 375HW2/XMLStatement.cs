namespace CSSE375HW2
{
	class XMLStatement: Statement
	{
		public override string HeaderString(Customer aCustomer)
		{
			return "<Statement><Name>" + aCustomer.GetName() + "</Name><Rentals>";
		}

		public override string SingleRentalString(Rental aRental)
		{
			return "<Rental><MovieName>" + aRental.GetMovie().GetTitle() + "</MovieName><CostToRent>" + aRental.GetCharge() + "</CostToRent></Rental>";
		}

		public override string FooterString(Customer aCustomer)
		{
			return "</Rentals><AmountOwed>" + aCustomer.GetTotalCharge() + "</AmountOwed><PointsEarned>" + aCustomer.GetTotalFrequentRenterPoints() +
			       "</PointsEarned></Statement>";
		}
	}
}
