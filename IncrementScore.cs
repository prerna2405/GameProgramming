using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementScore : MonoBehaviour {

	public UIcontroller controller;
	public Text score;

	public void changeScore(){
		score.text = "Score: " + controller.score.ToString ();
	}

}
