using CookieClicker.Runtime.Model;
using NUnit.Framework;

namespace CookieClicker.Tests.EditModeTests
{
	[TestFixture]
	public class PurchaseTests
	{
		[Test]
		public void PurchaseAutoclicker()
		{
			var doc = new Jar();
			var sut = new PurchaseAutoclicker(doc);

			sut.Execute();

			Assert.That(doc.isAutoclickerPurchased);
		}
	}

	public class PurchaseAutoclicker
	{
		readonly Jar jar;

		public PurchaseAutoclicker(Jar jar)
		{
			this.jar = jar;
		}

		public void Execute()
		{
			jar.PurchaseAutoclicker();
		}
	}
}
