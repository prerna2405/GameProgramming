using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsCorrect : MonoBehaviour {

	public UIcontroller controller;
	public Transform dropdown;

	public void Check(){
		//Debug.Log ("Chosen option is: " + dropdown.GetComponent<Dropdown> ().value);
		//Debug.Log ("Active panel is: " + (int.Parse (controller.activePanel.tag) - 1).ToString ());
		//Debug.Log ("Answer to 1st is: " + controller.answer [0].ToString ());
		//Debug.Log ("Answer to 1st is: " + controller.answer [(int.Parse (controller.activePanel.tag) - 1)].ToString ());
		if (dropdown.GetComponent<Dropdown> ().value == controller.answer[(int.Parse (controller.activePanel.tag) - 1)]) {
			//Debug.Log ("Answer to 1st is: " + controller.answer [(int.Parse (controller.activePanel.tag) - 1)].ToString ());
			//Debug.Log ("Flag value is: " + controller.flags [(int.Parse (controller.activePanel.tag) - 1)].ToString ());
			if (controller.flags [(int.Parse (controller.activePanel.tag) - 1)] == 0) {
				controller.score += 10;
			} else {
				controller.score += 5;
			}
		}

	}
		
}
