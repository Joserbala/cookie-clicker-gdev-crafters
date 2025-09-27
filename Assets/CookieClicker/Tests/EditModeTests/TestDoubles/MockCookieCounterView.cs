using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;

namespace CookieClicker.Tests.EditModeTests.TestDoubles
{
	public class MockCookieCounterView : IsdgsdgsdgView
	{
		public int Counter { get; private set; }

		public void Refresh(Jar jar)
		{
			Counter = jar.Amount;
		}
	}
}
