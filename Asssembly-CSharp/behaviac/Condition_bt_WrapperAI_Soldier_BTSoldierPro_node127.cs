using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Soldier_BTSoldierPro_node127 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint num = (uint)pAgent.GetVariable(2303639248u);
			uint num2 = (uint)pAgent.GetVariable(1128863647u);
			return (num != num2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
