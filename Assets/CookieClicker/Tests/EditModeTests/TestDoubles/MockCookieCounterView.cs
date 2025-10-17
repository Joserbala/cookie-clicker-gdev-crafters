using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;

namespace CookieClicker.Tests.EditModeTests.TestDoubles
{
	public class MockCookieCounterView : IGameView
	{
		readonly Jar jar;

		public MockCookieCounterView(Jar jar)
		{
			this.jar = jar;
		}

		public int Counter { get; private set; }

		public void Refresh()
		{
			Counter = jar.Amount;
		}
	}
}
