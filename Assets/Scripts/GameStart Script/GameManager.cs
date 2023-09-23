using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text percentText;
    public GameObject gameo;
    public GameObject Player;
    public Transform trans;
    Vector3 vec;
    Vector3 vec2;
    string[] str;
    int f;
    float deley = 0.5f;
    float time;
    public bool islive;

    private void Awake()
    {
        vec = transform.position;
        vec2 = Player.transform.position;
        islive = true;
        instance = this;
    }
    void Update()
    {
        if (islive)
        {
            time += Time.deltaTime;
            str = percentText.text.Split('%');
            f = int.Parse(str[0]);
            if (time > deley && Esc.instance.istrue)
            {
                f += 1;
                if (f < 101)
                {
                    percentText.text = f.ToString() + "%";
                    DataUpdate();
                    time = 0;
                }
            }
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    void DataUpdate()
    {
        str = percentText.text.Split('%');
        f = int.Parse(str[0]);

        if (GetData() < f)
        {
            PlayerPrefs.SetInt("BestPercent", f);
        }
    }

    int GetData()
    {
        int fl = PlayerPrefs.GetInt("BestPercent");
        return fl;
    }
}
