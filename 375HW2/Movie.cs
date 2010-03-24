using System;

namespace CSSE375HW2
{
	public class Movie {
		public const int Childrens = 2;
		public const int NewRelease = 1;
		public const int Regular = 0;
		private readonly String _title;
		private Price _price;

		public Movie(String title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		public void SetPriceCode(int arg)
		{
			switch (arg)
			{
				case Regular:
					_price = new RegularPrice();
					break;
				case Childrens:
					_price = new ChildrensPrice();
					break;
				case NewRelease:
					_price = new NewReleasePrice();
					break;
				default:
					throw new ArgumentException("Incorrect Price Code");
			}
		}

		public String GetTitle()
		{
			return _title;
		}

		public double GetCharge(int daysRented)
		{
			return _price.GetCharge(daysRented);
		}
		public int GetFrequentRenterPoints(int daysRented)
		{
			return _price.GetFrequentRenterPoints(daysRented);
		}
	}
}