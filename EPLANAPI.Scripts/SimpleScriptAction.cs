using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

namespace EPLANAPI.Scripts
{
    public class SimpleScriptAction
    {
        [DeclareAction("MyScriptAction")]
        public void MyFunctionAction()
        {
            new Decider().Decide(
                EnumDecisionType.eOkDecision,
                "Hello EPLAN API",
                "EPLAN API",
                EnumDecisionReturn.eCANCEL,
                EnumDecisionReturn.eOK
            );
        }

        [DeclareRegister]
        public void Register()
        {
            var ribbonBar = new Eplan.EplApi.Gui.RibbonBar();
            ribbonBar.AddCommand(
                "Hello EPlan",
                "MyScriptAction",
                Eplan.EplApi.Gui.CommandIcon.Circle_2
            );
        }

        [DeclareUnregister]
        public void UnRegister()
        {
            var ribbonBar = new Eplan.EplApi.Gui.RibbonBar();
            ribbonBar.RemoveCommand("MyScriptAction");
        }

        [DeclareEventHandler("onMainStart")]
        public void MyEventHandlerFunction()
        {
            new Decider().Decide(
                EnumDecisionType.eOkDecision,
                "EventHandler was called",
                "Event handler",
                EnumDecisionReturn.eOK,
                EnumDecisionReturn.eOK
            );
        }
    }
}
