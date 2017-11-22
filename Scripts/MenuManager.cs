using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public Button Yes;
	public Button No;

	public bool _isDead;

	void Start(){
		Yes.onClick.AddListener(delegate() { TaskOnClick("Play"); });
		No.onClick.AddListener(delegate() { TaskOnClick("Back"); });
	}

	void TaskOnClick(string option){
		if (option == "Play") {
			SceneManager.LoadScene ("Game");
			Debug.Log ("Play");
		} else if (option == "Back") {
			SceneManager.LoadScene ("Menu");
		}
	}
}