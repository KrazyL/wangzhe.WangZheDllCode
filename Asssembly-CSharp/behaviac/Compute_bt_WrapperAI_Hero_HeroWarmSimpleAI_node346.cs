using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Compute_bt_WrapperAI_Hero_HeroWarmSimpleAI_node346 : Compute
	{
		private uint opr2_p0;

		public Compute_bt_WrapperAI_Hero_HeroWarmSimpleAI_node346()
		{
			this.opr2_p0 = 30u;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int num = 5;
			int randomInt = ((BTBaseAgent)pAgent).GetRandomInt(this.opr2_p0);
			int value = num + randomInt;
			pAgent.SetVariable<int>("p_waitRandomFrames", value, 1456164896u);
			return result;
		}
	}
}
