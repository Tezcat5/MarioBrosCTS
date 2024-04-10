using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text scoureText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }

    void LoadScore()
    {
        scoureText.text = "Score: " + score.ToString();
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}