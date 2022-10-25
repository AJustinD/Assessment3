using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Button button;
    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1); 
    }

    public void LoadMainLevel()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(0);
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            button = GameObject.FindWithTag("QuitButton").GetComponent<Button>();
            button.onClick.AddListener(LoadMainLevel);
        }
    }



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
