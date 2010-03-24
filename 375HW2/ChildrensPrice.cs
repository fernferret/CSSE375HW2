namespace CSSE375HW2
{
	class ChildrensPrice : Price
	{
		public override int GetPriceCode()
		{
			return Movie.Childrens;
		}
		public override double GetCharge(int daysRented)
		{
			double result = 1.5;
			if(daysRented > 3)
			{
				result += (daysRented - 3)*1.5;
			}
			return result;
		}
	}
}
