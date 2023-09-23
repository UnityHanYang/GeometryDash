using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BChange : MonoBehaviour
{
    public Animator animator;
    public static BChange bChange;
    private int To;

    private void Start()
    {
        if(bChange == null)
        {
            bChange = this;
        }
    }

    public void FadeToLe(int level)
    {
        To = level;
        animator.SetTrigger("FadeOut");   
    }

    public void OnFadeCom()
    {
        SceneManager.LoadScene(To);
    }
}
