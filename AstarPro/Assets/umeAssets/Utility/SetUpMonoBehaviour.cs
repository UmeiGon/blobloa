using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpMonoBehaviour : MonoBehaviour {
    // Update is called once per frame
    bool isInit;
    void Update () {
        if (!isInit)
        {
            SetUp();
            isInit = true;
        }
        OUpdate();
	}
    protected virtual void SetUp()
    {

    }
    protected virtual void OUpdate()
    {

    }
}
