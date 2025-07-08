using System.Collections;
using CookieClicker.Runtime.View;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace CookieClicker.Tests.PlayModeTests
{
	public class CookieCounterTests
	{
		[UnityTest]
		public IEnumerator ClickingOnceEarnsOneCookie()
		{
			yield return SceneManager.LoadSceneAsync(0);
			yield return null;

			GameObject.Find("EarnCookie").GetComponent<Button>().onClick.Invoke();

			Assert.That(Object.FindAnyObjectByType<CookieCounter>().GetComponent<TMP_Text>().text,
				Is.EqualTo("1"));
		}

		[UnityTest]
		public IEnumerator ClickingThriceEarnsThreeCookies()
		{
			yield return SceneManager.LoadSceneAsync(0);
			yield return null;

			var button = GameObject.Find("EarnCookie").GetComponent<Button>();

			button.onClick.Invoke();
			button.onClick.Invoke();
			button.onClick.Invoke();

			var text = Object.FindAnyObjectByType<CookieCounter>().GetComponent<TMP_Text>().text;
			Assert.That(text, Is.EqualTo("3"));
		}

		[UnityTest]
		public IEnumerator ThreeCookiesAreAddedWhenThreeSecondsAndAHalfHavePassed()
		{
			yield return SceneManager.LoadSceneAsync(0);
			yield return null;

			yield return new WaitForSeconds(3.5f);

			var text = Object.FindAnyObjectByType<CookieCounter>().GetComponent<TMP_Text>().text;
			Assert.That(text, Is.EqualTo("3"));
		}

		[UnityTest]
		public IEnumerator AutoClickerDoesntStartUntilUpgradeIsPurchased()
		{
			yield return SceneManager.LoadSceneAsync(0);
			yield return null;

			yield return new WaitForSeconds(3.5f);

			var text = Object.FindAnyObjectByType<CookieCounter>().GetComponent<TMP_Text>().text;
			Assert.That(text, Is.EqualTo("0"));
		}
	}

	public class PurchaseAutoclickerButton : MonoBehaviour
	{
	}
}
