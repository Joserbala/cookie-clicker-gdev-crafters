using CookieClicker.Runtime.Model;

namespace CookieClicker.Runtime.Presenter
{
	public class EarnCookie
	{
		readonly Jar jar;
		readonly ICookieCounterView view;

		public EarnCookie(Jar jar, ICookieCounterView view)
		{
			this.jar = jar;
			this.view = view;
		}

		public void Execute()
		{
			jar.Add();
			view.Refresh();
		}
	}
}
