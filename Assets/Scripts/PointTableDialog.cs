// using Api;
using System;
using System.Collections.Generic;
using GGMatch3;
// using Images;
using TMPro;
using UnityEngine;

public class PointTableDialog : MonoBehaviour {

    private void OnEnable() {
        GGSoundSystem.Play(GGSoundSystem.SFXType.FlyIn);
    }
    
    public void ButtonCallback_ExitTable() {
        NavigationManager.instance.Pop(true);
        GGSoundSystem.Play(GGSoundSystem.SFXType.CancelPress);
        
    }

    // [SerializeField]
    // private Image testerImage;

    [SerializeField]
    private int tries = 10;

    [SerializeField]
    private float waitSeconds = 1f;
    
    private float lastClickTime;

    private int click;

}