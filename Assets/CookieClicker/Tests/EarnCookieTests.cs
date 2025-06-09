using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClicker.Tests
{
	[TestFixture]
	public class EarnCookieTests
	{
		[Test]
		public void EarnCookieAddsOneCookieToJar()
		{
			var doc = new Jar();
			var doc2 = new MockView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc.Amount(), Is.EqualTo(1));
		}

		[Test]
		public void EarnCookieUpdatesCookieCounter()
		{
			var doc = new Jar();
			var doc2 = new MockView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc2.hasBeenRefreshed, Is.EqualTo(true));
		}

		public class MockView : ICookieCounterView
		{
			public bool hasBeenRefreshed = false;
			public void Refresh()
			{
				hasBeenRefreshed = true;
			}
		}
	}


}
