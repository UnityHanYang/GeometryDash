using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    public static Esc instance;
    public GameObject gameob;
    AudioSource ausourc;
    public bool istrue;

    private void Start()
    {
        ausourc = GetComponent<AudioSource>();
        instance = this;
        istrue = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ausourc.isPlaying) ausourc.Pause();
            istrue = false;
            gameob.SetActive(true);
        }
    }
}
