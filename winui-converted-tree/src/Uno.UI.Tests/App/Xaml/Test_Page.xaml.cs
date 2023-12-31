﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Tests.App.Views;
using Uno.UI.Tests.ViewLibrary;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Tests.App.Xaml
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Test_Page : Page
	{
		public MyExtControl MyExtControl => myExtControl;
		public TextBlock TestTextBlock => testTextBlock;
		public TextBlock TestTextBlock2 => testTextBlock2;
		public Border TestBorder => testBorder;
		public ContentControl TestContentControl => testContentControl;
		public SpiffyItemsControl SpiffyItemsControl => spiffyItemsControl;
		public ProgressRing TestProgressRing => testProgressRing;
		public HyperlinkButton OuterHyperlinkButton => outerHyperlinkButton;
		public HyperlinkButton InnerHyperlinkButton => innerHyperlinkButton;
		public StackPanel TestStackPanel => testStackPanel;
		public RelativePanel TestRelativePanel => testRelativePanel;
		public TextBlock TestConditionalTextBlock => testConditionalTextBlock;

		private bool Boolean1 { get; } = true;
		private bool Boolean2 { get; } = false;

		public Test_Page()
		{
			this.InitializeComponent();
		}
	}
}
