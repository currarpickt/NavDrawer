using System;
using ReactiveUI;

namespace NavDrawer
{
	public class MenuViewModel : ReactiveObject
	{
		string _description;
		public string Description
		{
			get { return _description; }
			set { this.RaiseAndSetIfChanged(ref _description, value); }
		}

		string _iconName;
		public string IconName
		{
			get { return _iconName; }
			set { this.RaiseAndSetIfChanged(ref _iconName, value); }
		}	
	}
}
