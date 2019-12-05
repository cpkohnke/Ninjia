using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseUI : MonoBehaviour
{
    // Start is called before the first frame update
    private bool pause = false;
    public GameObject pauseUI;
    void Start()
    {
       pauseUI.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        //Press 'esc' key, Pause Menu appears
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        //When the Pause Menu actives, all character wont move
        if (pause)
        {

            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        //When the Pause Menu disappear, all character move normally
        if (pause == false)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        

    }
    //Press the button 'restart', game starts over again
    public void restart ()
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    //Press the button 'quit', it also means quit game 
    public void quit ()
        {
           Application.Quit();  
        }
}
