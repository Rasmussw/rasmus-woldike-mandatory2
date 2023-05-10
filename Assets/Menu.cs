using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Timer t;

    public void Update()
   {
      if (Input.GetKey(KeyCode.Escape))
      {
        MainMenu();
      }

      if (t == null)
      {

      }
       else if (t.timeToPlay <= 0)
      {
        
        SceneManager.LoadScene("GameOverScreen");
      }
   }

    public void Level1()
    {
        SceneManager.LoadScene("Game");
    }

     public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

     public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

     public void Quit()
    {
        #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

   public void MainMenu()
   {
      SceneManager.LoadScene("MainMenu");
   }

}
