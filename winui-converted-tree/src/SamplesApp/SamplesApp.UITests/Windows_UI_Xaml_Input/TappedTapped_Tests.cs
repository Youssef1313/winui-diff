﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using SamplesApp.UITests.TestFramework;
using Uno.UITest;
using Uno.UITest.Helpers;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;

namespace SamplesApp.UITests.Windows_UI_Xaml_Input
{
	public partial class Tapped_Tests : SampleControlUITestBase
	{
		private const string _xamlTestPage = "UITests.Shared.Windows_UI_Input.GestureRecognizerTests.TappedTest";

		[Test]
		[AutoRetry]
		public void When_Basic()
		{
			Run(_xamlTestPage);

			const string targetName = "Basic_Target";
			const int tapX = 10, tapY = 10;

			// Tap the target
			var target = _app.WaitForElement(targetName).Single().Rect;
			_app.TapCoordinates(target.X + tapX, target.Y + tapY);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			result.Element.Should().Be(targetName);
			((int)result.X).Should().BeInRange(tapX - 1, tapX + 1);
			((int)result.Y).Should().BeInRange(tapY - 1, tapY + 1);
		}

		[Test]
		[AutoRetry]
		[ActivePlatforms(Platform.Browser, Platform.iOS)] // Disabled on Android: The test engine is not able to find "Transformed_Target"
		public void When_Transformed()
		{
			Run(_xamlTestPage);

			const string parentName = "Transformed_Parent";
			const string targetName = "Transformed_Target";

			IAppRect parent, target;
			if (AppInitializer.TestEnvironment.CurrentPlatform == Platform.Browser)
			{
				// Workaround until https://github.com/unoplatform/Uno.UITest/pull/35 is merged

				parent = _app.Query(q => q.Marked(parentName)).Single().Rect;
				target = _app.Query(q => q.Marked(targetName)).Single().Rect;
			}
			else
			{
				parent = _app.Query(q => q.All().Marked(parentName)).Single().Rect;
				target = _app.Query(q => q.All().Marked(targetName)).Single().Rect;
			}

			var dpi = target.Width / 50;

			// Tap the target
			// Note: On WASM the parent is not clipped properly, so we must use absolute coordinates from top/left
			//		 https://github.com/unoplatform/uno/issues/2514
			_app.TapCoordinates(parent.X + 100 * dpi, parent.Y + (100 + 25) * dpi);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			result.Element.Should().Be(targetName);
		}

		[Test]
		[AutoRetry]
		[ActivePlatforms(Platform.Android, Platform.iOS)] // We cannot scroll to reach the target on WASM yet
		public void When_InScroll()
		{
			Run(_xamlTestPage);

			const string targetName = "InScroll_Target";
			const int tapX = 10, tapY = 10;

			// Scroll to make the target visible
			var scroll = _app.WaitForElement("InScroll_ScrollViewer").Single().Rect;
			_app.DragCoordinates(scroll.Right - 3, scroll.Bottom - 3, 0, 0);

			// Tap the target
			var target = _app.WaitForElement(targetName).Single();
			_app.TapCoordinates(target.Rect.X + tapX, target.Rect.Y + tapY);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			result.Element.Should().Be(targetName);
			((int)result.X).Should().Be(tapX);
			((int)result.Y).Should().Be(tapY);
		}

		[Test]
		[AutoRetry]
		[ActivePlatforms(Platform.Android, Platform.iOS)] // We cannot scroll to reach the target on WASM yet
		public void When_InListViewWithItemClick()
		{
			Run(_xamlTestPage);

			const string targetName = "ListViewWithItemClick";

			// Scroll a bit in the ListView
			var target = _app.WaitForElement(targetName).Single().Rect;
			_app.DragCoordinates(target.CenterX, target.Bottom - 3, target.CenterX, target.Y + 3);

			// Tap and hold an item
			_app.TapCoordinates(target.CenterX, target.CenterY - 5);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			var expectedItem = AppInitializer.GetLocalPlatform() == Platform.Browser
				? "Item_1" // We were not able to scroll on WASM!
				: "Item_3";
			result.Element.Should().Be(expectedItem);
		}

		[Test]
		[AutoRetry]
		[ActivePlatforms(Platform.Android, Platform.iOS)] // Disabled on WASM: False failure: https://github.com/unoplatform/uno/issues/2739
		public void When_InListViewWithoutItemClick()
		{
			Run(_xamlTestPage);

			const string targetName = "ListViewWithoutItemClick";

			// Scroll a bit in the ListView
			var target = _app.WaitForElement(targetName).Single().Rect;
			_app.DragCoordinates(target.CenterX, target.Bottom - 3, target.CenterX, target.Y + 3);

			// Tap and hold an item
			_app.TapCoordinates(target.CenterX, target.CenterY - 5);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			var expectedItem = AppInitializer.GetLocalPlatform() == Platform.Browser
				? "Item_1" // We were not able to scroll on WASM!
				: "Item_3";
			result.Element.Should().Be(expectedItem);
		}

		[Test]
		[AutoRetry]
		public void When_Nested()
		{
			Run(_xamlTestPage);

			const string parentName = "Nested_Parent";
			const string targetName = "Nested_Target";
			const int tapX = 10, tapY = 10;

			// Tap the target
			var target = _app.WaitForElement(targetName).Single().Rect;
			_app.TapCoordinates(target.X + tapX, target.Y + tapY);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			result.Element.Should().Be(parentName);
		}

		[Test]
		[AutoRetry]
		public void When_Nested_And_Handling()
		{
			Run(_xamlTestPage);

			const string targetName = "Nested_Handling_Target";
			const int tapX = 10, tapY = 10;

			// Tap the target
			var target = _app.WaitForElement(targetName).Single().Rect;
			_app.TapCoordinates(target.X + tapX, target.Y + tapY);

			var result = GestureResult.Get(_app.Marked("LastTapped"));
			result.Element.Should().Be(targetName);
			((int)result.X).Should().BeInRange(tapX - 1, tapX + 1);
			((int)result.Y).Should().BeInRange(tapY - 1, tapY + 1);
		}
	}
}
