using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

namespace EPLANAPI.Scripts
{
    public class SimpeScriptWithParameters
    {
        /// <summary>
        /// 在启动EPLAN时传递参数
        /// </summary>
        /// <remarks>
        /// .\W3u.exe ExecuteScript /ScriptFile:"C:\Users\Administrator\source\repos\EPLANAPI\EPLANAPI.Scripts\SimpeScriptWithParameters.cs" /param1:"Hello" /param2:"EPLAN" /param3:"API Developer"
        /// </remarks>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <returns></returns>
        [Start]
        public bool FunctionWithParameters(string param1, string param2, string param3)
        {
            new Decider().Decide(
                EnumDecisionType.eOkDecision,
                param1 + param2 + param3,
                "Paramters",
                EnumDecisionReturn.eOK,
                EnumDecisionReturn.eOK
            );
            return true;
        }
    }
}
