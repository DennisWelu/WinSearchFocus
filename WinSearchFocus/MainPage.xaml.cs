namespace WinSearchFocus
{
	public partial class MainPage
	{
		public MainPage() => InitializeComponent();

		private void OnSearchBarFocused(object? sender, FocusEventArgs e) => EventsEditor.Text = $"Search Focused {Environment.NewLine}{EventsEditor.Text}";
		private void OnSearchBarUnfocused(object? sender, FocusEventArgs e) => EventsEditor.Text = $"Search Unfocused {Environment.NewLine}{EventsEditor.Text}";

		private void OnEntryFocused(object? sender, FocusEventArgs e) => EventsEditor.Text = $"Entry Focused {Environment.NewLine}{EventsEditor.Text}";
		private void OnEntryUnfocused(object? sender, FocusEventArgs e) => EventsEditor.Text = $"Entry Unfocused {Environment.NewLine}{EventsEditor.Text}";
	}
}