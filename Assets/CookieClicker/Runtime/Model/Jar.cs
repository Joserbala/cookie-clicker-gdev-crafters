using System;

namespace CookieClicker.Runtime.Model
{
	public class Jar
	{
		public int Amount { get; private set; }

		public bool IsEmpty()
		{
			return Amount == 0;
		}

		public void Add()
		{
			Amount++;
		}

		public void OneSecondHasPassed()
		{
			Amount++;
		}

		public void SecondsHavePassed(float f)
		{
			Amount = Amount + (int)f;
		}
	}
}
