namespace CSSE375HW2
{
	class NewReleasePrice : Price
	{
		public override int GetPriceCode()
		{
			return Movie.NewRelease;
		}
		public override double GetCharge(int daysRented)
		{
			return daysRented*3;
		}
		public override int GetFrequentRenterPoints(int daysRented)
		{
			return (daysRented > 1) ? 2 : 1;
		}
	}
}
