using Microsoft.Extensions.DependencyInjection;

namespace Os;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	protected override void OnStartup(StartupEventArgs e)
	{
		ServiceLocator.ServiceProvider?.GetRequiredService<MainView>().Show();

		base.OnStartup(e);
	}
}