using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeftMove : MonoBehaviour
{
    public static LeftMove instance;
    private float speed = 10f;
    public bool istrue;
    private void Start()
    {
        instance = this;
        istrue = true;
    }

    private void Update()
    {
        StartCoroutine("MoveMap");
    }
    IEnumerator MoveMap()
    {
        if (istrue)
        {
            yield return new WaitForSeconds(0.9f);
        }
        if (GameManager.instance.islive && Esc.instance.istrue)
        {
            Debug.Log(speed);
            transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }
    }
}
