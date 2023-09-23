using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundS : MonoBehaviour
{

    public Material mt;

    private void Start()
    {
        mt = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        ColorChange.ccg.Move(mt, 0.1f);
        ColorChange.ccg.Change(this.gameObject);
    }
}
