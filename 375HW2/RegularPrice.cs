namespace CSSE375HW2
{
	class RegularPrice : Price
	{
		public override int GetPriceCode()
		{
			return Movie.Regular;
		}
		public override double GetCharge(int daysRented)
		{
			double result = 2;
			if(daysRented >2)
			{
				result += (daysRented - 2)*1.5;
			}
			return result;
		}
	}
}
