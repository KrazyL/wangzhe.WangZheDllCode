using System;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Hero_HeroCommonAutoAI_node919 : Assignment
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			bool value = true;
			pAgent.SetVariable<bool>("p_needGoHome", value, 1364365627u);
			return result;
		}
	}
}
