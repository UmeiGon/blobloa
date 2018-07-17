using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : IUnitBehaviour
{
    Unit unit;
    List<GameObject> panelList = new List<GameObject>();

    public MoveBehaviour(Unit _unit)
    {
        unit = _unit;
    }
    public void End()
    {
        foreach (var i in panelList)
        {
            GameObject.Destroy(i);
        }
        panelList.Clear();
    }
    List<Point2> canMovePoints;
    public void SetUp()
    {
        var lpp = CompornentUtility.FindCompornentOnScene<LightPanelPopper>();
        var unitMoveChecker = CompornentUtility.FindCompornentOnScene<UnitMoveChecker>();
        canMovePoints = unitMoveChecker.GetCanMovePoint(unit);
        foreach (var i in canMovePoints)
        {
            panelList.Add(lpp.PopPanel(i));
        }
    }

    public bool Update()
    {
        BlockPointGetter blockData = RightClickRayShot.GetMouseRayHitObject<BlockPointGetter>(KeyCode.Mouse0);
        if (blockData != null && (canMovePoints.Contains(blockData.point)))
        {
            unit.MoveToPoint(blockData.point);
            return true;
        }
        return false;
    }
}
