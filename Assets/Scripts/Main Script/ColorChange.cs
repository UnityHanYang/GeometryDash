using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    static public ColorChange ccg;

    static Color c1 = new Color(8 / 255f, 64 / 255f, 1f);
    static Color c2 = new Color(166 / 255f, 2 / 255f, 1f);
    static Color c3 = new Color(1f, 2 / 255f, 189 / 255f);
    static Color c4 = new Color(1f, 0f, 0f);
    static Color c5 = new Color(1f, 113 / 255f, 0f);
    static Color c6 = new Color(1f, 1f, 0f);
    static Color c7 = new Color(0f, 1f, 0f);
    static Color c8 = new Color(0f, 1f, 1f);

    static public Color[] targetColors = new Color[] { c1, c2, c3, c4, c5, c6, c7, c8 };
    private float changeDuration = 11f;

    private int currentIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        if(ccg == null)
        {
            ccg = this;
        }
    }

    public void Change(GameObject go) {
        timer += Time.deltaTime;
        if (timer > changeDuration)
        {
            currentIndex++;
            if (currentIndex >= targetColors.Length)
                currentIndex = 0;

            timer = 0f;
        }

        float t = timer / changeDuration;

        Color currentColor = targetColors[currentIndex];
        Color nextColor = targetColors[(currentIndex + 1) % targetColors.Length];
        Color lerpedColor = Color.Lerp(currentColor, nextColor, t);
        go.GetComponent<Renderer>().material.color = lerpedColor;
    }

    public void Move(Material mt, float speed)
    {
        Vector2 dir = Vector2.right;
        mt.mainTextureOffset += dir * speed * Time.deltaTime;

    }
}
