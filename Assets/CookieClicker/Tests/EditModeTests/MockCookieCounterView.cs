using CookieClicker.Runtime.Presenter;

namespace CookieClicker.Tests
{
	public class MockCookieCounterView : ICookieCounterView
	{
		public int Counter { get; private set; }

		public void Refresh(int amount)
		{
			Counter = amount;
		}
	}
}
