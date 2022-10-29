using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

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

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
