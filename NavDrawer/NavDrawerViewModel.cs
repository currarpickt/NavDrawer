using System;
using ReactiveUI;

namespace NavDrawer
{
	public enum MenuAction
	{
		None,
		Home,
		Settings,
		Search,
		Sync,
		Logout
	}

	public class NavDrawerViewModel : ReactiveObject
	{
		MenuAction _selectedMenu = MenuAction.None;
		public MenuAction SelectedMenu
		{
			get { return _selectedMenu; }
			set { this.RaiseAndSetIfChanged(ref _selectedMenu, value); }
		}

		string _menuDescription;
		public string MenuDescription
		{
			get { return _menuDescription; }
			set { this.RaiseAndSetIfChanged(ref _menuDescription, value); }
		}

		string _displayName;
		public string DisplayName
		{
			get { return _displayName; }
			set { this.RaiseAndSetIfChanged(ref _displayName, value); }
		}

		string _email;
		public string Email
		{
			get { return _email; }
			set { this.RaiseAndSetIfChanged(ref _email, value); }
		}

		public ReactiveList<MenuViewModel> AllMenu { get; set; }

		public NavDrawerViewModel()
		{
			this.DisplayName = "Hello";
			this.Email = "hello.world@project.com";
			this.MenuDescription = "Hello World!";
			SetAvailableMenu();
		}

		void SetAvailableMenu()
		{
			this.AllMenu = new ReactiveList<MenuViewModel>();
            this.AllMenu.Add(new MenuViewModel
			{
				Description = "Home",
				IconName = "HomeIcon"
			});
			this.AllMenu.Add(new MenuViewModel
			{
				Description = "Search",
				IconName = "SearchIcon"
			});
			this.AllMenu.Add(new MenuViewModel
			{
				Description = "Synchronisation",
				IconName = "SyncIcon"
			});
			this.AllMenu.Add(new MenuViewModel
			{
				Description = "Settings",
				IconName = "SettingIcon"
			});
			this.AllMenu.Add(new MenuViewModel
			{
				Description = "Logout",
				IconName = "LogoutIcon"
			});
		}
	}
}
