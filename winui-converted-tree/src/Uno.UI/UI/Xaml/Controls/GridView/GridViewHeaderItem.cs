﻿using System;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class GridViewHeaderItem : ListViewBaseHeaderItem
	{
#if !__WASM__
		public GridViewHeaderItem()
		{
			DefaultStyleKey = typeof(GridViewHeaderItem);
		}
#endif
	}
}
