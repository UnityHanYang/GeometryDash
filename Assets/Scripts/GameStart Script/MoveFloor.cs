using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
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
            ParentC.par.Move(mt, 0.5f);
            yield return null;
        }
    }
}
