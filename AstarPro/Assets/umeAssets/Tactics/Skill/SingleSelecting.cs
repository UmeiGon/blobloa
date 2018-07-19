using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleSelecting : SelectingTargetType
{
    int targetRange;
    public override List<Point2> Selecting(Unit _user, KeyCode _key)
    {
        Unit targetUnit = RightClickRayShot.GetMouseRayHitObject<Unit>(_key);
        if (!targetUnit) return null;
        if (!StageUtility.IsInnerOnCross(_user.pos,targetUnit.pos,targetRange)) return null;
        return new List<Point2>() {targetUnit.pos };

    }
    SingleSelecting(int target_range)
    {
        targetRange = target_range;
    }
}
