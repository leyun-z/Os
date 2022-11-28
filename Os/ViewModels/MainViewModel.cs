using Os.Models;
using System.Collections.ObjectModel;

namespace Os.ViewModels;

public partial class MainViewModel : ObservableObject
{
	public MainViewModel()
	{
		//	初始化菜单栏
		InitializeMenus();
	}

	[ObservableProperty]
	private string _title = "Test";

	[ObservableProperty]
	private ObservableCollection<Menu> _menus = new();

	[ObservableProperty]
	private Student _student = new Student()
	{
		Name = "张文俊",
		Sno = "1033200319",
		Class = "计科2003班"
	};

	private void InitializeMenus()
	{
		_menus.Add(new Menu()
		{
			Icon = new Uri("/Resources/ProcessScheduling.png", UriKind.Relative),
			Detail = "进程调度",
			Content = new Uri("/Views/ProcessSchedulingView.xaml", UriKind.Relative)
		});
		_menus.Add(new Menu()
		{
			Icon = new Uri("/Resources/TaskScheduling.png", UriKind.Relative),
			Detail = "作业调度",
			Content = new Uri("/Views/TaskSchedulingView.xaml", UriKind.Relative)
		});
		_menus.Add(new Menu()
		{
			Icon = new Uri("/Resources/StorageManagement.png", UriKind.Relative),
			Detail = "存储管理",
			Content = new Uri("/Views/StorageManagementView.xaml", UriKind.Relative)
		});
		_menus.Add(new Menu()
		{
			Icon = new Uri("/Resources/FileManagement.png", UriKind.Relative),
			Detail = "文件管理",
			Content = new Uri("/Views/FileManagementView.xaml", UriKind.Relative)
		});
		_menus.Add(new Menu()
		{
			Icon = new Uri("/Resources/BankerAlgorithm.png", UriKind.Relative),
			Detail = "银行家算法",
			Content = new Uri("/Views/BankerAlgorithmView.xaml", UriKind.Relative)
		});
	}
}
