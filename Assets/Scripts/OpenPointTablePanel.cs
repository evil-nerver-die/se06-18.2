using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenPointTablePanel : MonoBehaviour {

    public void Hide() {
        GGUtil.Hide(this);
    }

    public void ButtonCallBack_OnPressedTable() {
        NavigationManager instance = NavigationManager.instance;
        PointTableDialog object3 = instance.GetObject<PointTableDialog>();
        instance.Push(object3, false);
    }

}