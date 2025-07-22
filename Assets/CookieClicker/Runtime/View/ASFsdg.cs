using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class ASFsdg : MonoBehaviour
	{
		PassTime passTime;

		void Update()
		{
			passTime.Execute(Time.deltaTime);
		}

		public void Initialize(PassTime inPassTime)
		{
			passTime = inPassTime;
		}
	}
}
