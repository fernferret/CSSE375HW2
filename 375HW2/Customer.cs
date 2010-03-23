using System;
using System.Collections.Generic;

namespace CSSE375HW2
{
	public class Customer
	{
		private readonly String _name;
		private readonly List<Rental> _rentals = new List<Rental>();
		
		public Customer(String name)
		{
			_name = name;
		}
		public void AddRental(Rental arg)
		{
			_rentals.Add(arg);
		}
		public String GetName()
		{
			return _name;
		}
		public String Statement()
		{
			double totalAmount = 0;
			int frequentRenterPoints = 0;
			String result = "Rental Record for " + GetName() + "\n";
			foreach (var rental in _rentals)
			{
				frequentRenterPoints += rental.GetFrequentRenterPoints();
				// show figures for this rental
				result += "\t" + rental.GetMovie().GetTitle() + "\t" + rental.GetCharge() + "\n";
				totalAmount += rental.GetCharge();
			}
			// add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
		}
	}
}