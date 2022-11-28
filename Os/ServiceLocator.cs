using Microsoft.Extensions.DependencyInjection;

namespace Os;

public static class ServiceLocator
{
	static ServiceLocator()
	{
		ConfigServices();
	}

	private static void ConfigServices()
	{
		ServiceCollection services = new();

		services.AddSingleton<MainView>();
		services.AddSingleton<MainViewModel>();

		_serviceProvider = services.BuildServiceProvider();
	}

	private static ServiceProvider? _serviceProvider;

	public static ServiceProvider? ServiceProvider { get { return _serviceProvider; } }
}
