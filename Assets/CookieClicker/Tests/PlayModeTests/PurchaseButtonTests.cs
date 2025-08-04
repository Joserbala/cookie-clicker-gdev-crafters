using System.Collections;
using CookieClicker.Runtime.View;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace CookieClicker.Tests.PlayModeTests
{
	public class PurchaseButtonTests
	{
		[UnityTest]
		public IEnumerator Sasdgafsdg()
		{

			yield return SceneManager.LoadSceneAsync(0);
			yield return null;

			var autoClickerButton = Object.FindAnyObjectByType<PurchaseAutoclickerButton>().GetComponent<Button>();

			Assert.That(autoClickerButton.enabled, Is.False);
		}
	}
}
