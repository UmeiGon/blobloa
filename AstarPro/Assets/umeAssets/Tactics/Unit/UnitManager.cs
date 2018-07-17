using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class UnitManager : MonoBehaviour {
    Dictionary<int, List<Unit>> unitDic;
    List<Unit> unitList=new List<Unit>();
    public Dictionary<int, List<Unit>> Units
    {
        get { return unitDic; }
    }

    void InitArmy()
    {
        unitDic = new Dictionary<int, List<Unit>>();
        //army(陣営)毎にunitのlistを作成
        foreach (var a in Enum.GetValues(typeof(Army)))
        {
            unitDic.Add((int)a, new List<Unit>());
        }
    }
    //unitが存在している陣営のみのlistを返す。
    public List<Army> GetArmyList()
    {
        List<Army> armyList=new List<Army>();
        foreach (var a in unitDic)
        {
            if(a.Value.Count>0)armyList.Add((Army)a.Key);
        }
        return armyList;
    }
    public List<Point2> GetStandingList()
    {
        List<Point2> pointList = new List<Point2>();
        foreach (var i in unitList)
        {
            pointList.Add(i.pos);
        }
        return pointList;
    }
    public void AddUnit(Unit _unit)
    {
        if (unitDic == null)
        {
            InitArmy();
        }
        unitDic[(int)_unit.Army].Add(_unit);
        unitList.Add(_unit);
    }
}
