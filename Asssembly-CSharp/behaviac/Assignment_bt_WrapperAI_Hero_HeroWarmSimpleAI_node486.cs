using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Hero_HeroWarmSimpleAI_node486 : Assignment
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int sightArea = ((ObjAgent)pAgent).GetSightArea();
			pAgent.SetVariable<int>("p_srchRange", sightArea, 2451377514u);
			return result;
		}
	}
}
