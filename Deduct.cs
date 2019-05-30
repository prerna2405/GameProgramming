using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduct : MonoBehaviour {

	public UIcontroller controller;

	public void changeFlag(){
		controller.flags [(int.Parse (controller.activePanel.tag) - 1)] = 1;
	}

}
