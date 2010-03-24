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
			//double totalAmount = 0;
			int frequentRenterPoints = 0;
			String result = "Rental Record for " + GetName() + "\n";
			foreach (var rental in _rentals)
			{
				// show figures for this rental
				result += "\t" + rental.GetMovie().GetTitle() + "\t" + rental.GetCharge() + "\n";
			}
			// add footer lines
			result += "Amount owed is " + GetTotalCharge() + "\n";
			result += "You earned " + GetTotalFrequentRenterPoints() + " frequent renter points";
			return result;
		}
		private double GetTotalCharge()
		{
			double result = 0;
			foreach (var rental in _rentals)
			{
				result += rental.GetCharge();
			}
			return result;
		}
		private int GetTotalFrequentRenterPoints()
		{
			int result = 0;
			foreach (var rental in _rentals)
			{
				result += rental.GetFrequentRenterPoints();
			}
			return result;
		}
		public String HtmlStatement()
		{
			String result = "<h1>Rentals for <em>" + GetName() + "</em></h1></p>\n";
			foreach (var rental in _rentals)
			{
				// Show figures for each rental
				result += rental.GetMovie().GetTitle() + ": " + rental.GetCharge() + "<br />\n";
			}
			// Add footer lines
			result += "<p>You owe <em>" + GetTotalCharge() + "</em></p>\n";
			result += "On this rental you earned <em>" + GetTotalFrequentRenterPoints() + "</em> frequent renter points</p>";
			return result;
		}
	}
}