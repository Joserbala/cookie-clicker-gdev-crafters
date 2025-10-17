﻿using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class GameView : MonoBehaviour, IGameView
	{
		Jar jar;

		public void Initialize(Jar jar)
		{
			this.jar = jar;
			FindFirstObjectByType<CookieCounter>().Refresh(0);
		}

		public void Refresh()
		{
			FindFirstObjectByType<CookieCounter>().Refresh(jar.Amount);
			FindFirstObjectByType<PurchaseAutoclickerButton>().Refresh(jar.Amount, jar.AutoclickerPrice);
		}
	}
}
