using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
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
}
