using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : SetUpMonoBehaviour
{
    [SerializeField] Army army;
    public Army Army { get { return army; } }
    [SerializeField]UnitStatus unitStatus;
    public UnitStatus GetUnitStatus{get { return unitStatus; }}
    UnitStatus maxUnitStatus;
    public UnitStatus GetMaxUnitStatus {get{ return maxUnitStatus; } }

    Mover mover;
    public Point2 pos;
    public void MoveToPoint(Point2 _point)
    {
        mover.MoveToPoint(_point);
    }
    private void Awake()
    {
        mover = new Mover(this);
        maxUnitStatus = unitStatus;
        Debug.Log(unitStatus);
        Debug.Log(maxUnitStatus);
        CompornentUtility.FindCompornentOnScene<UnitManager>().AddUnit(this);
    }
    protected override void SetUp()
    {
        transform.position = CompornentUtility.FindCompornentOnScene<BattleStage>().GetBlockPosition(pos);
    }
}
