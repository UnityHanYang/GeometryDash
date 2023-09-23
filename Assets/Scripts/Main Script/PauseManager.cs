using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static PauseManager instance;
    public bool isPause = false;

    private void Awake()
    {
        instance = this;
    }
}
