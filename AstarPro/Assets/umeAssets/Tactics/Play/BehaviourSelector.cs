using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourSelector :SetUpMonoBehaviour
{
    IUnitBehaviour unitBehaviour;
    // Use this for initialization
    protected override void SetUp()
    {
        UnitSetUp();
    }
    void UnitSetUp()
    {
        var unit = CompornentUtility.FindCompornentOnScene<UnitSelector>().ActivUnit;
        unitBehaviour = new MoveBehaviour(unit);
        unitBehaviour.SetUp();
    }
    // Update is called once per frame
    protected override void OUpdate()
    {
        if (unitBehaviour.Update())
        {
            unitBehaviour.End();
            CompornentUtility.FindCompornentOnScene<TurnManager>().NextTurn();
            UnitSetUp();
        }
    }
}
