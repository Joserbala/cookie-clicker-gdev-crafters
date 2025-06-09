using System.Collections;
using CookieClicker.Runtime.View;
using NUnit.Framework;
using TMPro;
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

			UnityEngine.Object.FindAnyObjectByType<Button>().onClick.Invoke();

			Assert.That(UnityEngine.Object.FindAnyObjectByType<CookieCounter>().GetComponent<TMP_Text>().text,
				Is.EqualTo("1"));
		}
	}
}
