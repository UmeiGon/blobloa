using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efe_Heal : SkillEffect
{
    int healValue;
    protected override void Effect(List<Unit> unit_list)
    {
        foreach (var u in unit_list)
        {
            u.ReciveHeal(healValue);
        }
    }
    public Efe_Heal(int heal_value)
    {
        healValue = heal_value;
    }
}
