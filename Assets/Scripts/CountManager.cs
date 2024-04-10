using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountManager : MonoBehaviour
{
   public Text countText;
   public int countGoomba;

    // Update is called once per frame
    void Start()
    {
        countGoomba = 0;
    }
    public void LoadGoombaCount(){
        countGoomba++;
        countText.text = "Goombas: "+countGoomba.ToString();
    }
}
