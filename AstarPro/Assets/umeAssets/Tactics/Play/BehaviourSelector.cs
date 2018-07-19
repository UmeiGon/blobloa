using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourSelector :MonoBehaviour
{
    IUnitBehaviour unitBehaviour;
    // Use this for initialization
    private void Start()
    {
        CompornentUtility.FindCompornentOnScene<SetUpManager>().AddSetUpAction(UnitSetUp);
    }
    void UnitSetUp()
    {
        var unit = CompornentUtility.FindCompornentOnScene<UnitSelector>().ActivUnit;
        unitBehaviour = new MoveBehaviour(unit);
        unitBehaviour.SetUp();
    }
    // Update is called once per frame
private void Update()
    {
        if (unitBehaviour.Update())
        {
            unitBehaviour.End();
            CompornentUtility.FindCompornentOnScene<TurnManager>().NextTurn();
            UnitSetUp();
        }
    }
}
