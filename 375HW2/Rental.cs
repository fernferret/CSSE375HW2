namespace CSSE375HW2
{
	public class Rental
	{
		private readonly Movie _movie;
		private readonly int _daysRented;
		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}
		public int GetDaysRented()
		{
			return _daysRented;
		}
		public Movie GetMovie()
		{
			return _movie;
		}
		public double GetCharge()
		{
			return _movie.GetCharge(_daysRented);
		}
		public int GetFrequentRenterPoints()
		{
			return _movie.GetFrequentRenterPoints(_daysRented);
		}
	}
}