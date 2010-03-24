using CSSE375HW2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentalTest
{
	[TestClass]
	public class MainTest
	{
		#region Test Base Cases
		[TestMethod]
		public void TestCreateMovie()
		{
			var m = new Movie("Test", 2);
			Assert.IsNotNull(m);
		}
		[TestMethod]
		public void TestCreateRental()
		{
			var m = new Movie("Test", 2);
			var r = new Rental(m,4);
			Assert.IsNotNull(r);
		}
		[TestMethod]
		public void TestCreateCustomer()
		{
			var c = new Customer("Eric");
			Assert.IsNotNull(c);
		}
		#endregion

		#region Test Very Basic Creations
		[TestMethod]
		public void TestCreateCustomerName()
		{
			var name = "Eric";
			var c = new Customer(name);
			Assert.AreEqual(c.GetName(),name);
		}
		[TestMethod]
		public void TestCreatenewRental()
		{
			var m = new Movie("Test", 2);
			var r = new Rental(m, 4);
			Assert.AreEqual(r.GetMovie(), m);
		}
		#endregion

		#region Test Regular, NewRelease, Childrens
		[TestMethod]
		public void TestRentRegular()
		{
			var name = "Eric";
			var movieTitle = "The Shawshank Redemption";
			var priceCode = Movie.Regular;
			var daysRented = 4;
			var c = new Customer(name);
			var m = new Movie(movieTitle, priceCode);
			var r = new Rental(m, daysRented);

			c.AddRental(r);
			Assert.AreEqual(c.Statement(), "Rental Record for " + name + "\n\t" + movieTitle + "\t5\nAmount owed is 5\nYou earned 1 frequent renter points");
		}
		public void TestRentNewRelease()
		{
			var name = "Eric";
			var movieTitle = "Law Abiding Citizen";
			var priceCode = Movie.NewRelease;
			var daysRented = 4;
			var c = new Customer(name);
			var m = new Movie(movieTitle, priceCode);
			var r = new Rental(m, daysRented);

			c.AddRental(r);
			Assert.AreEqual(c.Statement(), "Rental Record for " + name + "\n\t" + movieTitle + "\t3\nAmount owed is 3\nYou earned 1 frequent renter points");
		}
		public void TestRentChildrens()
		{
			var name = "Eric";
			var movieTitle = "UP";
			var priceCode = Movie.Childrens;
			var daysRented = 4;
			var c = new Customer(name);
			var m = new Movie(movieTitle, priceCode);
			var r = new Rental(m, daysRented);

			c.AddRental(r);
			Assert.AreEqual(c.Statement(), "Rental Record for " + name + "\n\t" + movieTitle + "\t3\nAmount owed is 3\nYou earned 1 frequent renter points");
		}
		#endregion

		#region Test Multiple Rentals
		[TestMethod]
		public void TestTwoRental()
		{
			var m = new Movie("Taken", Movie.NewRelease);
			var m2 = new Movie("The Rock", Movie.Regular);
			var r = new Rental(m, 4);
			var r2 = new Rental(m2, 5);
			var c = new Customer("Eric");
			c.AddRental(r);
			c.AddRental(r2);
			Assert.AreEqual(c.Statement(), "Rental Record for Eric\n\tTaken\t12\n\tThe Rock\t6.5\nAmount owed is 18.5\nYou earned 3 frequent renter points");
		}
		[TestMethod]
		public void TestMultiRental()
		{
			var m = new Movie("Taken", Movie.NewRelease);
			var m2 = new Movie("The Rock", Movie.Regular);
			var m3 = new Movie("300", Movie.NewRelease);
			var m4 = new Movie("Bambi", Movie.Childrens);
			var r = new Rental(m, 4);
			var r2 = new Rental(m2, 5);
			var r3 = new Rental(m3, 2);
			var r4 = new Rental(m4, 7);

			var c = new Customer("Eric");
			c.AddRental(r);
			c.AddRental(r2);
			c.AddRental(r3);
			c.AddRental(r4);
			Assert.AreEqual(c.Statement(), "Rental Record for Eric\n\tTaken\t12\n\tThe Rock\t6.5\n\t300\t6\n\tBambi\t7.5\nAmount owed is 32\nYou earned 6 frequent renter points");
		}
		[TestMethod]
		public void TestZeroRental()
		{
			var c = new Customer("Eric");
			Assert.AreEqual(c.Statement(), "Rental Record for Eric\nAmount owed is 0\nYou earned 0 frequent renter points");
		}
		#endregion

		#region Test Multiple Rentals HTML version
		[TestMethod]
		public void TestTwoRentalHtml()
		{
			var m = new Movie("Taken", Movie.NewRelease);
			var m2 = new Movie("The Rock", Movie.Regular);
			var r = new Rental(m, 4);
			var r2 = new Rental(m2, 5);
			var c = new Customer("Eric");
			c.AddRental(r);
			c.AddRental(r2);
			Assert.AreEqual(c.HtmlStatement(), "<h1>Rentals for <em>Eric</em></h1></p>\nTaken: 12<br />\nThe Rock: 6.5<br />\n<p>You owe <em>18.5</em></p>\nOn this rental you earned <em>3</em> frequent renter points</p>");
		}
		[TestMethod]
		public void TestMultiRentalHtml()
		{
			var m = new Movie("Taken", Movie.NewRelease);
			var m2 = new Movie("The Rock", Movie.Regular);
			var m3 = new Movie("300", Movie.NewRelease);
			var m4 = new Movie("Bambi", Movie.Childrens);
			var r = new Rental(m, 4);
			var r2 = new Rental(m2, 5);
			var r3 = new Rental(m3, 2);
			var r4 = new Rental(m4, 7);

			var c = new Customer("Eric");
			c.AddRental(r);
			c.AddRental(r2);
			c.AddRental(r3);
			c.AddRental(r4);
			Assert.AreEqual(c.HtmlStatement(), "<h1>Rentals for <em>Eric</em></h1></p>\nTaken: 12<br />\nThe Rock: 6.5<br />\n300: 6<br />\nBambi: 7.5<br />\n<p>You owe <em>32</em></p>\nOn this rental you earned <em>6</em> frequent renter points</p>");
		}
		[TestMethod]
		public void TestZeroRentalHtml()
		{
			var c = new Customer("Eric");
			Assert.AreEqual(c.HtmlStatement(), "<h1>Rentals for <em>Eric</em></h1></p>\n<p>You owe <em>0</em></p>\nOn this rental you earned <em>0</em> frequent renter points</p>");
		}
		#endregion

		#region Finally Test Invalid PriceCode
		[TestMethod]
		public void TestInalidPriceCode()
		{
			var name = "Eric";
			var movieTitle = "Test";
			var priceCode = 5;
			var daysRented = 4;
			var c = new Customer(name);
			var m = new Movie(movieTitle, priceCode);
			var r = new Rental(m, daysRented);

			c.AddRental(r);
			Assert.AreEqual(c.Statement(), "Rental Record for " + name + "\n\t" + movieTitle + "\t0\nAmount owed is 0\nYou earned 1 frequent renter points");
		}
		#endregion
	}
}
