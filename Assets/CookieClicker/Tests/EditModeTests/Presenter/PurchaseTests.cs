using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using CookieClicker.Tests.EditModeTests.TestDoubles;
using NUnit.Framework;

namespace CookieClicker.Tests.EditModeTests.Presenter
{
	[TestFixture]
	public class PurchaseTests
	{
		[Test]
		public void PurchaseAutoclicker()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new PurchaseAutoclicker(doc, doc2);

			sut.Execute();

			Assert.That(doc.isAutoclickerPurchased);
		}

		[Test]
		public void AutoclickerCantBePurchasedWithoutEnoughCookies()
		{
			var doc = new Jar(3);
			var doc2 = new MockCookieCounterView();
			var sut = new PurchaseAutoclicker(doc, doc2);

			sut.Execute();

			Assert.That(doc.isAutoclickerPurchased, Is.False);
		}

		[Test]
		public void AutoclickerCanBePurchasedWithEnoughCookies()
		{
			var doc = new Jar(3).WithCookies(3);
			var doc2 = new MockCookieCounterView();
			var sut = new PurchaseAutoclicker(doc, doc2);

			sut.Execute();

			Assert.That(doc.isAutoclickerPurchased);
		}
	}
}
