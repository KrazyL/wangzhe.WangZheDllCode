using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroWarmNormalAI_node365 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			int num = (int)pAgent.GetVariable(3421255u);
			int num2 = 1;
			return (num >= num2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
