using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public Material mt;

    private void Start()
    {
        StartCoroutine("MoveMap");
    }
    IEnumerator MoveMap()
    {
        yield return new WaitForSeconds(1f);

        while (GameManager.instance.islive && Esc.instance.istrue)
        {
            ParentC.par.Move(mt, 0.1f);
            yield return null;
        }
    }
}
