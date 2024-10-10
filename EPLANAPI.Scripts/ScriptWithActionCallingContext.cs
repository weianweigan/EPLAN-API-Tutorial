using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

namespace EPLANAPI.Scripts
{
    public class ScriptWithActionCallingContext
    {
        /// <summary>
        /// 在启动EPLAN时传递参数
        /// </summary>
        /// <remarks>
        /// .\W3u.exe ExecuteScript /ScriptFile:"C:\Users\Administrator\source\repos\EPLANAPI\EPLANAPI.Scripts\ScriptWithActionCallingContext.cs" /param1:"Hello" /param2:"EPLAN" /param3:"API Developer"
        /// </remarks>
        [Start]
        public void FunctionWithActionCallingContext(ActionCallingContext ctx)
        {
            string? param1 = null;
            string? param2 = null;
            string? param3 = null;

            ctx.GetParameter("param1", ref param1);
            ctx.GetParameter("param2", ref param2);
            ctx.GetParameter("param3", ref param3);

            new Decider().Decide(
                EnumDecisionType.eOkDecision,
                param1 + param2 + param3,
                "Paramters",
                EnumDecisionReturn.eOK,
                EnumDecisionReturn.eOK
            );
        }
    }
}
