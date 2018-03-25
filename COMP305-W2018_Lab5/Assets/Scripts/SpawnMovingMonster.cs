using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovingMonster : MonoBehaviour {

    float timer = 0;
    public GameObject newObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float range = Random.Range(-10, 10);
        float timerRange = Random.Range(1, 5);
        Vector3 newPosition = new Vector3(GameObject.Find("player").transform.position.x + range, transform.position.y + Mathf.Abs(range), 0);
        if(timer >= timerRange)
        {
            GameObject t = (GameObject)(Instantiate(newObject, newPosition, Quaternion.identity));
            timer = 0;
        }
	}
}
