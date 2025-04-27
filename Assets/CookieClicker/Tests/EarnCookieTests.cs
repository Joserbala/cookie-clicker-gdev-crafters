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
			var sut = new EarnCookie(doc);

			sut.Execute();

			Assert.That(doc.Amount(), Is.EqualTo(1));
		}
	}
}
