using Eplan.EplApi.ApplicationFramework;
using System.Windows;

namespace EPLANAPI.EplAddin.SampleAddin;

/// <summary>
/// 插件注册和卸载流程：
/// <list type="bullet">
/// <item>
/// 注册调用顺序：<see cref="OnRegister(ref bool)"/> -> <see cref="OnInit"/> -> <see cref="OnInitGui"/>
/// </item>
/// <item>
/// 卸载调用顺序：<see cref="OnExit"/> -> <see cref="OnUnregister"/>
/// </item>
/// </list>
/// </summary>
public class AddInModule : IEplAddIn
{
    public bool OnExit()
    {
        return true;
    }

    public bool OnInit()
    {
        return true;
    }

    public bool OnInitGui()
    {
        return true;
    }

    /// <summary>
    /// 文件->附加->扩展->接口-> 加载
    /// </summary>
    /// <param name="bLoadOnStart"></param>
    /// <returns></returns>
    public bool OnRegister(ref bool bLoadOnStart)
    {
        bLoadOnStart = true;
        MessageBox.Show(typeof(AddInModule).Assembly.Location);
        return true;
    }

    /// <summary>
    /// 文件->附加->扩展->接口-> 卸载
    /// </summary>
    /// <returns></returns>
    public bool OnUnregister()
    {
        return true;
    }
}
