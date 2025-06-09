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
		public void ViewDisplays1Cookie()
		{
			var doc = new Jar();
			var doc2 = new MockView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(1));
		}

		[Test]
		public void ViewDisplays2Cookies()
		{
			var doc = new Jar();
			var doc2 = new MockView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();
			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(2));
		}

		public class MockView : ICookieCounterView
		{
			public int Counter { get; private set; }

			public void Refresh(int amount)
			{
				Counter = amount;
			}
		}
	}
}
