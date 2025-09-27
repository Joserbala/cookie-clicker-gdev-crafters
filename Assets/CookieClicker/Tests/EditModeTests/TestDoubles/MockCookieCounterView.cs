using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;

namespace CookieClicker.Tests.EditModeTests.TestDoubles
{
	public class MockCookieCounterView : IGameView
	{
		public int Counter { get; private set; }

		public void Refresh(Jar jar)
		{
			Counter = jar.Amount;
		}
	}
}
