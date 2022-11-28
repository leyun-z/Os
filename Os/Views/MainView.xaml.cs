using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Os.Views;

/// <summary>
/// MainView.xaml 的交互逻辑
/// </summary>
public partial class MainView : Window
{
	public MainView(MainViewModel viewModel)
	{
		InitializeComponent();

		DataContext = viewModel;

		//	注册无边框窗口行为事件
		RegisterEvent();
	}

	/// <summary>
	/// 注册窗口的一些交互逻辑
	/// </summary>
	private void RegisterEvent()
	{
		//	窗口任意位置按下可以移动
		MouseDown += (s, e) =>
		{
			if (e.LeftButton is MouseButtonState.Pressed)
			{
				DragMove();
			}
		};

		//	监听窗口大小变化
		SizeChanged += (s, e) =>
		{
			if (WindowState == WindowState.Maximized)
			{
				//	改变图标
				if (BtnMax.Content is Image image)
				{
					var closeImageSource = new BitmapImage(new Uri("/Resources/normal.png", UriKind.Relative));
					image.Source = closeImageSource;
				}
			}
			else if (WindowState == WindowState.Minimized)
			{
			}
			else if (WindowState == WindowState.Normal)
			{
				//	改变图标
				if (BtnMax.Content is Image image)
				{
					var closeImageSource = new BitmapImage(new Uri("/Resources/max.png", UriKind.Relative));
					image.Source = closeImageSource;
				}
			}
		};

		//	标题栏按钮事件
		BtnMin.Click += (s, e) => { WindowState = WindowState.Minimized; };
		BtnMax.Click += (s, e) =>
		{
			WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
		};
		BtnClose.Click += (s, e) => { Close(); };
	}
}
