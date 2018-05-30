using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backtomenuu : MonoBehaviour {

	private Button button;
	 void Start()
    {
       button = gameObject.GetComponent<Button>();
       button.onClick.AddListener(BacktoMenu);
    }

    void BacktoMenu()
    {
        SceneManager.LoadScene(0); //Loads the main menu scene
    }
}
