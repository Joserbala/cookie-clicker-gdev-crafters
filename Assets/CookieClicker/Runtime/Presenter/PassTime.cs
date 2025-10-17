using CookieClicker.Runtime.Model;

namespace CookieClicker.Runtime.Presenter
{
	public class PassTime
	{
		readonly Jar jar;
		readonly IGameView view;

		public PassTime(Jar jar, IGameView view)
		{
			this.jar = jar;
			this.view = view;
		}

		public void Execute(float time)
		{
			var amountBeforeTimePassing = jar.Amount;
			jar.SecondsHavePassed(time);

			if (jar.Amount != amountBeforeTimePassing)
			{
				view.Refresh(jar);
			}
		}
	}
}
