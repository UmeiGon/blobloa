using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillEffect {
    protected abstract void Effect(List<Unit> unit_list);
   public void Effect(List<Point2> p_list)
    {
        var units=CompornentUtility.FindCompornentOnScene<UnitManager>().GetStandingUnits(p_list);
        Effect(units);
    }
}
