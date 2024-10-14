using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.EServices;
using System.Diagnostics;
using System.Windows;

namespace EPLANAPI.EplAddin.SampleAddin;

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
        Debugger.Break();
        string path = typeof(AddInModule).Assembly.Location;
        MessageBox.Show(path);
        bLoadOnStart = true;
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
