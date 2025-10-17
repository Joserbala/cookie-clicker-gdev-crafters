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

		public static Jar WithAutoclicker(this Jar jar)
		{
			for (var i = 0; i < jar.AutoclickerPrice; i++)
			{
				jar.Add();
			}

			jar.PurchaseAutoclicker();

			return jar;
		}
	}
}
