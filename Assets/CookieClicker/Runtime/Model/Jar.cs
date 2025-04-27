namespace CookieClicker.Runtime.Model
{
	public class Jar
	{
		int cookies;

		public bool IsEmpty()
		{
			return cookies == 0;
		}

		public void Add()
		{
			cookies++;
		}

		public int Amount()
		{
			return cookies;
		}
	}
}
