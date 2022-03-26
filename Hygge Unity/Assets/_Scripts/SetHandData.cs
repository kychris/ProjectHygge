using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dirox.emotiv.controller;
using EmotivUnityPlugin;
using UnityEngine.UI;

public class SetHandData : MonoBehaviour
{
    [SerializeField] DataSubscriber subsriber;

    [SerializeField] private Text focusData;       // performance metric data
    [SerializeField] private Text relaxData;       // performance metric data
    [SerializeField] private Text stressData;       // performance metric data

    void Start()
    {
        focusData.text = "0";
        relaxData.text = "0";
        stressData.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        focusData.text = subsriber.focusPMData.text;
        relaxData.text = subsriber.relaxPMData.text;
        stressData.text = subsriber.stressPMData.text; ;
    }
}
