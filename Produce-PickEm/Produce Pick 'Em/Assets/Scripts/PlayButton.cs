using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour {

	private Button button;
	 void Start()
    {
       button = gameObject.GetComponent<Button>();
       button.onClick.AddListener(Play);
    }

    void Play()
    {
        SceneManager.LoadScene(1); //Loads the play scene
    }
}
