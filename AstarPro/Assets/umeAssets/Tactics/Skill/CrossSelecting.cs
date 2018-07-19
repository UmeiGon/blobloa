using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSelecting : SelectingTargetType
{
    int effectRange;
    int targetRange;
    public override List<Point2> Selecting(Unit _user,KeyCode _key)
    {
        var pointGetter = RightClickRayShot.GetMouseRayHitObject<BlockPointGetter>(_key);
        if (pointGetter != null)
        {
            var crossPoints =StageUtility.GetCrossPoint(pointGetter.point,effectRange);
            return crossPoints;
        }
        return null;
    }
    public CrossSelecting(int target_range,int effect_range)
    {
        targetRange = target_range;
        effectRange = effect_range;
    }
}
