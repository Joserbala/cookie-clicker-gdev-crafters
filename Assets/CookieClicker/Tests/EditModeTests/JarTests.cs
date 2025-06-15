using CookieClicker.Runtime.Model;
using NUnit.Framework;

namespace CookieClicker.Tests
{
	[TestFixture]
	public class JarTests
	{
		[Test]
		public void JarIsEmptyByDefault()
		{
			var jar = new Jar();

			Assert.That(jar.IsEmpty(), Is.True);
		}

		[Test]
		public void EarnOneCookieJarIsNotEmpty()
		{
			var jar = new Jar();

			jar.Add();

			Assert.That(jar.IsEmpty(), Is.False);
		}

		[Test]
		public void EarnOneCookie()
		{
			var jar = new Jar();

			jar.Add();

			Assert.That(jar.Amount, Is.EqualTo(1));
		}

		[Test]
		public void EarnTwoCookies()
		{
			var jar = new Jar();

			jar.Add();
			jar.Add();

			Assert.That(jar.Amount, Is.EqualTo(2));
		}

		[Test]
		public void CookieIsAddedWhenOneSecondHasPassed()
		{
			var jar = new Jar();

			jar.OneSecondHasPassed();

			Assert.That(jar.Amount, Is.EqualTo(1));
		}

		[TestCase(3f, 3)]
		[TestCase(3.9f, 3)]
		[TestCase(3.2f, 3)]
		public void ThreeCookiesAreAddedWhenThreeSecondsHavePassed(float timePassed, int amountOfCookies)
		{
			var jar = new Jar();

			jar.SecondsHavePassed(timePassed);

			Assert.That(jar.Amount, Is.EqualTo(amountOfCookies));
		}

		[Test]
		public void sdgsg()
		{
			var jar = new Jar();

			jar.SecondsHavePassed(0.6f);
			jar.SecondsHavePassed(0.6f);

			Assert.That(jar.Amount, Is.EqualTo(1));
		}

		[Test]
		public void sdgsg2()
		{
			var jar = new Jar();

			jar.SecondsHavePassed(1.6f);
			jar.SecondsHavePassed(1.6f);

			Assert.That(jar.Amount, Is.EqualTo(3));
		}
	}
}
