﻿using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClicker.Tests.EditModeTests
{
	[TestFixture]
	public class EarnCookieTests
	{
		[Test]
		public void EarnCookieAddsOneCookieToJar()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc.Amount, Is.EqualTo(1));
		}

		[Test]
		public void ViewDisplays1Cookie()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(1));
		}

		[Test]
		public void ViewDisplays2Cookies()
		{
			var doc = new Jar();
			var doc2 = new MockCookieCounterView();
			var sut = new EarnCookie(doc, doc2);

			sut.Execute();
			sut.Execute();

			Assert.That(doc2.Counter, Is.EqualTo(2));
		}

		[Test]
		public void PassTime()
		{
			var doc = new Jar();
			doc.PurchaseAutoclicker();
			var doc2 = new MockCookieCounterView();
			var sut = new PassTime(doc, doc2);

			sut.Execute(1.2f);

			Assert.That(doc.Amount, Is.EqualTo(1));
		}

		[Test]
		public void AfterPassingTimeViewDisplays1Cookie()
		{
			var doc = new Jar();
			doc.PurchaseAutoclicker();
			var doc2 = new MockCookieCounterView();
			var sut = new PassTime(doc, doc2);

			sut.Execute(1.2f);

			Assert.That(doc2.Counter, Is.EqualTo(1));
		}

		[Test]
		public void AfterPassingTimeMultipleTimesViewDisplaysUpdatedCounter()
		{
			var doc = new Jar();
			doc.PurchaseAutoclicker();
			var doc2 = new MockCookieCounterView();
			var sut = new PassTime(doc, doc2);

			sut.Execute(1.2f);
			sut.Execute(1.2f);
			sut.Execute(1.2f);

			Assert.That(doc2.Counter, Is.EqualTo(3));
		}
	}
}
