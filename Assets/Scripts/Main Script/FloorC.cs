using UnityEngine;

public class FloorC : MonoBehaviour
{
    public Material mt;
    private void Start()
    {
        mt = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        ColorChange.ccg.Move(mt, 0.3f);
        ColorChange.ccg.Change(this.gameObject);
    }
}
