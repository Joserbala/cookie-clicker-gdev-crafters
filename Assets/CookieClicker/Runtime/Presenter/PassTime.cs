using CookieClicker.Runtime.Model;

namespace CookieClicker.Runtime.Presenter
{
	public class PassTime
	{
		readonly Jar jar;
		readonly IsdgsdgsdgView view;

		public PassTime(Jar jar, IsdgsdgsdgView view)
		{
			this.jar = jar;
			this.view = view;
		}

		public void Execute(float time)
		{
			jar.SecondsHavePassed(time);
			view.Refresh(jar.Amount);
		}
	}
}
