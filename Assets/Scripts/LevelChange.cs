using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour
{
    public static LevelChange instance;
    public Animator animator;
    public GameObject aniImg;
    private int level;

    private void Start()
    {
        instance = this;
    }
    public void FadeToLelel(int index)
    {
        level = index;
        aniImg.SetActive(true);
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(level);
    }
}
