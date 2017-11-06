using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Monster_BTMonsterPassive_node163 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			int monsterEndurance = ((ObjAgent)pAgent).GetMonsterEndurance();
			int num = 0;
			return (monsterEndurance <= num) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
