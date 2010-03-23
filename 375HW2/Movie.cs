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
	}
}