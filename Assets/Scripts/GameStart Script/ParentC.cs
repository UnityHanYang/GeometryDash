using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentC : MonoBehaviour
{
    static public ParentC par;

    private void Awake()
    {
        par = this;
    }
    public void Move(Material mt, float speed)
    {
        Vector2 dir = Vector2.right;
        mt.mainTextureOffset += dir * speed * Time.deltaTime;

    }
}
