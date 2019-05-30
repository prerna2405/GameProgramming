using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour {

	public GameObject[] UiPanels;
	public GameObject activePanel;
	public int score;
	public GameObject prevPanel;
	//public int[] answers = new int[]{2, 1, 2, 1, 3};
	public int[] answer = new int[]{2,1,2,1,3};
	public int[] flags = new int[]{0,0,0,0,0}; 
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			Debug.Log (UiPanels [i].tag);
		}
		//UiPanels [0].SetActive(false);
		for(int i=1; i< 5; i++)
		{
			UiPanels[i].SetActive(false);
		}
		activePanel = UiPanels [0];
	}
}
