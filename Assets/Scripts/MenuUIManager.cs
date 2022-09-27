using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        PersistenceManager.Instance.name = name;

        SceneManager.LoadScene(1);
    }

    public void ChangeName(string nameInput)
    {
        name = nameInput;
    }

    public void Exit()
    {
        PersistenceManager.Instance.SaveHighScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
