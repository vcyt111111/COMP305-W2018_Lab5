using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScores : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("scoreUI1").GetComponent<Text>().text = "Score:" + Stick.count1;
        GameObject.Find("scoreUI2").GetComponent<Text>().text = "Score:" + Stick.count2;
        GameObject.Find("scoreUI3").GetComponent<Text>().text = "Score:" + Stick.count3;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
