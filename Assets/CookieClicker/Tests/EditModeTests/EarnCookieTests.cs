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
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc.Amount, Is.EqualTo(1));
		}

		[Test]
		public void ViewDisplays1Cookie()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(1));
		}

		[Test]
		public void ViewDisplays2Cookies()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();
			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(2));
		}

		[Test]
		public void PassTime()
		{
			var doc = new Jar();
			var sut = new PassTime(doc);

			sut.Execute(1.2f);

			Assert.That(doc.Amount, Is.EqualTo(1));
		}
	}

	public class PassTime
	{
		readonly Jar jar;

		public PassTime(Jar jar)
		{
			this.jar = jar;
		}

		public void Execute(float time)
		{
			jar.SecondsHavePassed(time);
		}
	}
}
