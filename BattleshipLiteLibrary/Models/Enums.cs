using System;
namespace BattleshipLiteLibrary.Models
{
	public enum GridSpotStatus
	{
        // 0 = empty, 1 = ship, 2 = miss, 3 = hit, 4 = sunk
        Empty,
        Ship,
        Miss,
        Hit,
        Sunk
    }
}

