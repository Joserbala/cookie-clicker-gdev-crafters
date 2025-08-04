using CookieClicker.Runtime.Model;

namespace CookieClicker.Tests.EditModeTests
{
	public static class Helper
	{
		public static Jar WithCookies(this Jar jar, int initialAmount)
		{
			for (var i = 0; i < initialAmount; i++)
			{
				jar.Add();
			}

			return jar;
		}
	}
}
