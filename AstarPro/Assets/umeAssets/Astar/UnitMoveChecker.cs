using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMoveChecker : MonoBehaviour
{
    BattleStage battleStage;
    PathCreater pathCreater;
    private void Awake()
    {
        battleStage = CompornentUtility.FindCompornentOnScene<BattleStage>();
        pathCreater = CompornentUtility.FindCompornentOnScene<PathCreater>();
    }
    public List<Point2> GetCanMovePoint(Unit _unit)
    {
        List<Point2> standingList = CompornentUtility.FindCompornentOnScene<UnitManager>().GetStandingList();
        List<Point2> canMovePoints = new List<Point2>();
        Point2 pivot = _unit.pos;
        int moveRange = _unit.GetUnitStatus.moveRange;


        for (int i = pivot.x - moveRange; i <= pivot.x + moveRange; i++)
        {
            for (int k = pivot.y - moveRange; k <= pivot.y + moveRange; k++)
            {
                var point = new Point2(i, k);
                if (standingList.Contains(point))continue;
                    var subPoint = pivot - point;
                //動ける範囲かチェック
                if (subPoint.AbsSum() > moveRange) continue;
                var pathList = pathCreater.GetPath(_unit.pos, point,_unit.GetUnitStatus.stepHeight);
                if (pathList == null) continue;
                //実際のルートを辿り動けるかチェック
                if (pathList.Count > moveRange) continue;
                canMovePoints.Add(point);
            }
        }
        return canMovePoints;
    }
}
