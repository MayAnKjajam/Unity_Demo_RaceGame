using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMEpLAYcONTROLLER : MonoBehaviour {
    public GameObject PausePanel;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
   
}

