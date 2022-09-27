using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIManager : MonoBehaviour
{
    public Text NameText;
    public Text HighScoreText;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (PersistenceManager.Instance.HighScoreName != null)
        {
            HighScoreText.text = "Best Score: " + PersistenceManager.Instance.HighScoreName + ": " + PersistenceManager.Instance.HighScore;
        }
    }

    private void Awake()
    {        
        if (PersistenceManager.Instance.HighScoreName != null)
        {
            HighScoreText.text = "Best Score: " + PersistenceManager.Instance.HighScoreName + ": " + PersistenceManager.Instance.HighScore;
        }
    }
    
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
