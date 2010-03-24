using System;

namespace CSSE375HW2
{
	public class Movie {
		public const int Childrens = 2;
		public const int NewRelease = 1;
		public const int Regular = 0;
		private readonly String _title;
		private int _priceCode;

		public Movie(String title, int priceCode)
		{
			_title = title;
			_priceCode = priceCode;
		}

		public int GetPriceCode()
		{
			return _priceCode;
		}

		public void SetPriceCode(int arg)
		{
			_priceCode = arg;
		}

		public String GetTitle()
		{
			return _title;
		}

		public double GetCharge(int daysRented)
		{
			double result = 0;
			switch (GetPriceCode())
			{
				// The qualifier, 'Movies' is redundant here
				case Regular:
					result += 2;
					if (daysRented > 2)
						result += (daysRented - 2)*1.5;
					break;
				case NewRelease:
					result += daysRented*3;
					break;
				case Childrens:
					result += 1.5;
					if (daysRented > 3)
						result += (daysRented - 3)*1.5;
					break;
			}
			return result;
		}
		public int GetFrequentRenterPoints(int daysRented)
		{
			if ((GetPriceCode() == NewRelease) && daysRented > 1)
				return 2;
			return 1;
		}
	}
}