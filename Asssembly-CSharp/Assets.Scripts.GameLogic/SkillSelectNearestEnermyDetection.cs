using ResData;
using System;

namespace Assets.Scripts.GameLogic
{
	[SkillBaseDetection(SkillUseRule.EnermyUse)]
	public class SkillSelectNearestEnermyDetection : SkillBaseDetection
	{
		public override bool Detection(SkillSlot slot)
		{
			int srchR;
			if (slot.SkillObj.AppointType == SkillRangeAppointType.Target)
			{
				srchR = slot.SkillObj.GetMaxSearchDistance(slot.GetSkillLevel());
			}
			else
			{
				srchR = slot.SkillObj.cfgData.iMaxAttackDistance;
			}
			return Singleton<TargetSearcher>.GetInstance().GetNearestEnemy(slot.Actor.handle, srchR, slot.SkillObj.cfgData.dwSkillTargetFilter, true) != null;
		}
	}
}
