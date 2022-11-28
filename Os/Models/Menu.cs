namespace Os.Models;

public record Menu
{
	/// <summary>
	/// 按钮的图标，为一个资源文件
	/// </summary>
	public Uri? Icon { get; set; }

	/// <summary>
	/// 按钮文字介绍
	/// </summary>
	public string? Detail { get; set; }

	/// <summary>
	/// 按钮对应显示的内容
	/// </summary>
	public Uri? Content { get; set; }
}
