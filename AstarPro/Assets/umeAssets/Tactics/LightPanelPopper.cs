using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanelPopper : MonoBehaviour {
    [SerializeField]
    GameObject LightPanelPre;
    public GameObject PopPanel(Point2 _point)
    {
        var battleStage=CompornentUtility.FindCompornentOnScene<BattleStage>();
        Vector3 pos=battleStage.GetBlockPosition(_point);
        var obj = Instantiate(LightPanelPre);
        obj.transform.position = pos;
        return obj;
    }
}
