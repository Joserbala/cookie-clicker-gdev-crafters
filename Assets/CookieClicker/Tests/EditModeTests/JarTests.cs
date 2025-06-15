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
		public void Asdgasfghinkafgh()
		{
			var jar = new Jar();

			jar.OneSecondHasPassed();

			Assert.That(jar.Amount, Is.EqualTo(1));
		}

		[Test]
		public void Asdgasfghinkafgh2()
		{
			var jar = new Jar();

			jar.SecondsHavePassed(3f);

			Assert.That(jar.Amount, Is.EqualTo(3));
		}

		[Test]
		public void Asdgasfghinkafgh3()
		{
			var jar = new Jar();

			jar.SecondsHavePassed(3.9f);

			Assert.That(jar.Amount, Is.EqualTo(3));
		}

		[Test]
		public void Asdgasfghinkafgh4()
		{
			var jar = new Jar();

			jar.SecondsHavePassed(3.2f);

			Assert.That(jar.Amount, Is.EqualTo(3));
		}
	}
}
