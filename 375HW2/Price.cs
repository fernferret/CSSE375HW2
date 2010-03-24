namespace CSSE375HW2
{
	abstract class Price
	{
		public abstract int GetPriceCode();
		public abstract double GetCharge(int daysRented);
		public virtual int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}
}
