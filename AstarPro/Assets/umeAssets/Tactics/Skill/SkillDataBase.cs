using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    Kearu, Fire, Tuki
}

public static class SkillDataBase
{
    Dictionary<int, Skill> skills=new Dictionary<int, Skill>();
    public static Skill GetSkill(this SkillType skill_type){

    }
}
