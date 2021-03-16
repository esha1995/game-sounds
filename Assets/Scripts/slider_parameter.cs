using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_parameter : MonoBehaviour
{

    public Slider slider;
    public float startValue;
    public string paremeter = "";

    void Start()
    {
        slider.value = startValue;
    }

    void Update()
    {
        AkSoundEngine.SetRTPCValue(paremeter, slider.value);
    }

}
