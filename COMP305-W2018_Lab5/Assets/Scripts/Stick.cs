using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour {

    public static int count1 = 0;
    public static int count2 = 0;
    public static int count3 = 0;

    public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "monster1")
            count1++;
        if (collision.gameObject.tag == "monster2")
            count2++;
        if (collision.gameObject.tag == "monster3")
            count3++;

        GameObject exp = (GameObject)(Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity));
        Destroy(exp, .5f);
        Destroy(collision.gameObject);
        Destroy(gameObject, 10);
        GameObject.Find("uiScore1").GetComponent<Text>().text = "Score:" + count1;
        GameObject.Find("uiScore2").GetComponent<Text>().text = "Score:" + count2;
        GameObject.Find("uiScore3").GetComponent<Text>().text = "Score:" + count3;
    }
}
