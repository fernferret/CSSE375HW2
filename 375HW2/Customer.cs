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
			return new TextStatement().Value(this);
		}
		public List<Rental> GetRentals()
		{
			return _rentals;
		}
		public double GetTotalCharge()
		{
			double result = 0;
			foreach (var rental in _rentals)
			{
				result += rental.GetCharge();
			}
			return result;
		}
		public int GetTotalFrequentRenterPoints()
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
			return new HtmlStatement().Value(this);
		}
		public String XMLStatement()
		{
			return new XMLStatement().Value(this);
		}
	}
}