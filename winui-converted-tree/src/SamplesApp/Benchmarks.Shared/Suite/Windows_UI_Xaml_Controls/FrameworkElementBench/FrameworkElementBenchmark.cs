﻿using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace SamplesApp.Benchmarks.Suite.Windows_UI_Xaml_Controls.FrameworkElementBench
{
	public class FrameworkElementBenchmark
	{
		private Border SUT;

		[GlobalSetup]
		public void Setup()
		{
			SUT = new Border();
		}

		[Benchmark()]
		public void Toggle_Style()
		{
			SUT.Style = new Microsoft.UI.Xaml.Style();
			SUT.ClearValue(Border.StyleProperty);
		}
	}
}
