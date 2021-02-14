using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader levelLoader;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Singleton();    
    }

    void Singleton()
    {
        if (levelLoader != null)
            Destroy(gameObject);
        else
        {
            levelLoader = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene(int index)
    {
        anim.Play("Fade");
        StartCoroutine(loadScene(index));
    }

    IEnumerator loadScene(int index)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(index);
    }
}
