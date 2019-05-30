using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour {

	public UIcontroller controller;
	public IsCorrect checkValue;
	public IncrementScore inc;

	public void Change(){
		checkValue.Check ();
		inc.changeScore ();
		controller.prevPanel = controller.activePanel;
		controller.prevPanel.SetActive (false);
		controller.activePanel = controller.UiPanels [int.Parse(controller.prevPanel.tag)];
		controller.activePanel.SetActive (true);
	}

}
