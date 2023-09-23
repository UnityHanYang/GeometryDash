using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartToScene : MonoBehaviour
{
    RectTransform btnRect;
    RectTransform imgRect;
    RectTransform shadowRect;
    public GameObject Btn;
    public GameObject Img;
    public GameObject shadow;
    bool istrue;

    private void Start()
    {
        btnRect = Btn.GetComponent<RectTransform>();
        imgRect = Img.GetComponent<RectTransform>();
        shadowRect = shadow.GetComponent<RectTransform>();
    }
    public void MouseDown()
    {
        if (!PauseManager.instance.isPause)
        {
            btnRect.sizeDelta = new Vector2(370, 390);
            imgRect.sizeDelta = new Vector2(430, 430);
            shadowRect.sizeDelta = new Vector2(430, 430);
        }
    }
    public void MouseUp()
    {
        if (!PauseManager.instance.isPause)
        {
            btnRect.sizeDelta = new Vector2(315.658f, 335.4745f);
            imgRect.sizeDelta = new Vector2(381, 381);
            shadowRect.sizeDelta = new Vector2(381, 381);
            LevelChange.instance.FadeToLelel(1);
        }
    }
}
