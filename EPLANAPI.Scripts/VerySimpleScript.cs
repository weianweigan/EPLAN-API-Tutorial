using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

namespace EPLANAPI.Scripts
{
    public class VerySimpleScript
    {
        [Start]// 必须的，EPLAN会根据这个Attribute来查找脚本的入口
        public void MyFunction()
        {
            new Decider().Decide(
                EnumDecisionType.eOkDecision, 
                "Hello EPLAN API", 
                "EPLAN API", 
                EnumDecisionReturn.eCANCEL, 
                EnumDecisionReturn.eOK);
        }
    }
}
