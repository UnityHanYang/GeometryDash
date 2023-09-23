using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percent : MonoBehaviour
{
    public Text text;
    string[] str;
    private Slider sli;
    public GameObject go;

    private void Awake()
    {
        sli = GetComponent<Slider>();
    }

    private void Update()
    {
        str = text.text.Split('%');
        if (int.Parse(str[0]) < 101 && int.Parse(str[0]) >= 0)
        {
            sli.value = int.Parse(str[0]);
        }

        if(sli.value == 100)
        {
            go.SetActive(true);
        }
    }


}
