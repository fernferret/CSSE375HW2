using System;

namespace CSSE375HW2
{
	abstract class Statement
	{
		public String Value(Customer aCustomer)
		{
			var rentals = aCustomer.GetRentals();
			String result = HeaderString(aCustomer);
			foreach (var rental in rentals)
			{
				// show figures for this rental
				result += SingleRentalString(rental);
			}
			// add footer lines
			result += FooterString(aCustomer);
			return result;
		}

		public abstract String HeaderString(Customer aCustomer);
		public abstract String SingleRentalString(Rental aRental);
		public abstract String FooterString(Customer aCustomer);
	}
}
