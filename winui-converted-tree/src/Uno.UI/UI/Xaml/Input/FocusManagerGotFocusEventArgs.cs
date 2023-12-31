﻿#nullable enable

using System;

namespace Microsoft.UI.Xaml.Input
{
	/// <summary>
	/// Provides data for the GotFocus event.
	/// </summary>
	public partial class FocusManagerGotFocusEventArgs
	{
		internal FocusManagerGotFocusEventArgs(DependencyObject? newFocusedElement, Guid correlationId)
		{
			NewFocusedElement = newFocusedElement;
			CorrelationId = correlationId;
		}

		/// <summary>
		/// Gets the most recent focused element.
		/// </summary>
		public DependencyObject? NewFocusedElement { get; internal set; }

		/// <summary>
		/// Gets the unique ID generated when a focus movement event is initiated.
		/// </summary>
		/// <remarks>
		/// Each time a focus event is initiated, a unique CorrelationId is generated
		/// to help you track a focus event throughout these focus actions.
		/// A new CorrelationId is generated when:
		/// - The user moves focus.
		/// - The app moves focus using methods such as Control.Focus or FocusManager.TryFocusAsync.
		/// - The app gets/loses focus due to window activation(see CoreWindow.Activated ).
		/// </remarks>
		public Guid CorrelationId { get; internal set; }
	}
}
