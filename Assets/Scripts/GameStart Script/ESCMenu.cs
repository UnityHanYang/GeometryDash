using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCMenu : MonoBehaviour
{
    public GameObject go;
    public void MenuScene()
    {
        LevelChange.instance.FadeToLelel(1);
    }

    public void Retry()
    {
        LevelChange.instance.FadeToLelel(2);
    }

    public void StartToClick()
    {
        go.SetActive(false);
        PlayerController.instance.isH = true;
        LeftMove.instance.istrue = false;
        Esc.instance.istrue = true;
    }
}
