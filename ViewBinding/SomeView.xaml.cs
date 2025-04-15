using System.Collections.ObjectModel;

namespace ViewBinding;

public partial class SomeView : ContentView
{
	public static readonly BindableProperty SomeItemsProperty = BindableProperty.Create(nameof(SomeItems), typeof(ObservableCollection<string>), typeof(SomeView));
	public static readonly BindableProperty SomeTextProperty = BindableProperty.Create(nameof(SomeText), typeof(string), typeof(SomeView));

	public SomeView()
	{
		InitializeComponent();
	}

	public ObservableCollection<string> SomeItems
	{
		get => (ObservableCollection<string>)GetValue(SomeItemsProperty);
		set => SetValue(SomeItemsProperty, value);
	}
	public string SomeText
	{
		get => (string)GetValue(SomeTextProperty);
		set => SetValue(SomeTextProperty, value);
	}
}