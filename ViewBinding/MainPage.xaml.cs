using System.Collections.ObjectModel;

namespace ViewBinding
{
	public partial class MainPage : ContentPage
	{
		public static readonly BindableProperty BindableStringsProperty = BindableProperty.Create(nameof(BindableStrings), typeof(ObservableCollection<string>), typeof(MainPage));

		public MainPage()
		{
			BindableStrings = ["One", "Two", "Three" ];
			Strings = [ "A", "B", "C" ];

			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			if (Title == null)
			{
				Title = "Test";
			}
			else
			{
				Title = null;
			}
		}

		public ObservableCollection<string> BindableStrings
		{
			get => (ObservableCollection<string>)GetValue(BindableStringsProperty);
			set => SetValue(BindableStringsProperty, value);
		}

		public ObservableCollection<string> Strings { get; set; }
	}
}
