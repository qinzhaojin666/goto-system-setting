﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAction : MonoBehaviour {

    string actionForSettings = "pui.settings.action.SETTINGS";
    string actionForBluetooth = "pui.settings.action.BLUETOOTH_SETTINGS";
    string actionForWifi = "pui.settings.action.WIFI_SETTINGS";

    string actionForController = "pui.settings.action.CONTROLLER_SETTINGS";
    // Use this for initialization
    void Start () {

        
	}

	// Update is called once per frame
	void Update () {

	}
	public void startActionSettings()
	{
		startToAction(actionForSettings);
	}
    public void startActionBluetooth()
    {
        startToAction(actionForBluetooth);
    }
    public void startActionWifi()
    {
        startToAction(actionForWifi);
    }
    public void startActionController()
    {
        startToAction(actionForController);
    }
    private void startToAction(string action)
	{
		AndroidJavaClass jcPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject joActivity = jcPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject joIntent = new AndroidJavaObject("android.content.Intent", action);
		joActivity.Call("startActivity", joIntent);
	}
}
