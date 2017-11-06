using System;

namespace CSProtocol
{
	public enum COM_CLIENT_PLAY_TYPE
	{
		COM_CLIENT_PLAY_NULL,
		COM_CLIENT_PLAY_ADVENTURE = 2,
		COM_CLIENT_PLAY_BURNING = 4,
		COM_CLIENT_PLAY_ARENA = 8,
		COM_CLIENT_PLAY_LADDER = 16,
		COM_CLIENT_PLAY_REWARDMATCH = 32,
		COM_CLIENT_PLAY_MATCH = 64,
		COM_CLIENT_PLAY_ENTERTAINMENT = 128,
		COM_CLIENT_PLAY_PKAI = 256,
		COM_CLIENT_PLAY_ROOM = 512
	}
}
