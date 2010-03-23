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
				double thisAmount = 0;
				//determine amounts for each line

				thisAmount = AmountFor(rental);
				
				// add frequent renter points
				frequentRenterPoints++;
				// add bonus for a two day new release rental
				if ((rental.GetMovie().GetPriceCode() ==
				     Movie.NewRelease) &&
				    rental.GetDaysRented() > 1)
					frequentRenterPoints++;
				// show figures for this rental
				result += "\t" + rental.GetMovie().GetTitle() + "\t" + thisAmount + "\n";
				totalAmount += thisAmount;
			}
			// add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
		}
		private double AmountFor(Rental r)
		{
			double thisAmount = 0;
			switch (r.GetMovie().GetPriceCode())
			{
				case Movie.Regular:
					thisAmount += 2;
					if (r.GetDaysRented() > 2)
						thisAmount += (r.GetDaysRented() - 2) * 1.5;
					break;
				case Movie.NewRelease:
					thisAmount += r.GetDaysRented() * 3;
					break;
				case Movie.Childrens:
					thisAmount += 1.5;
					if (r.GetDaysRented() > 3)
						thisAmount += (r.GetDaysRented() - 3) * 1.5;
					break;
			}
			return thisAmount;
		}
	}
}