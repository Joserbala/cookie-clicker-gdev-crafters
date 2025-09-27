using CookieClicker.Runtime.Model;

namespace CookieClicker.Runtime.Presenter
{
	public class EarnCookie
	{
		readonly Jar jar;
		readonly IsdgsdgsdgView view;

		public EarnCookie(Jar jar, IsdgsdgsdgView view)
		{
			this.jar = jar;
			this.view = view;
		}

		public void Execute()
		{
			jar.Add();
			view.Refresh(jar);
		}
	}
}
