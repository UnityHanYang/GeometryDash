using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public Text text;
    string[] str;
    private Slider sli;

    private void Awake()
    {
        sli = GetComponent<Slider>();
    }

    private void Update()
    {
        str = text.text.Split('%');
        if (int.Parse(str[0]) < 101 && int.Parse(str[0]) >= 0)
        {
            sli.value = float.Parse(str[0]);
        }
    }
}
