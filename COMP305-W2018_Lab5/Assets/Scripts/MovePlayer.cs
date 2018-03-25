using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour {

    public GameObject stick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            gameObject.transform.Translate(Vector3.left * 0.1f);
        if (Input.GetKey(KeyCode.RightArrow))
            gameObject.transform.Translate(Vector3.right * 0.1f);
        if (Input.GetKey(KeyCode.UpArrow))
            gameObject.transform.Translate(Vector3.up * 0.1f);
        if (Input.GetKey(KeyCode.DownArrow))
            gameObject.transform.Translate(Vector3.down * 0.1f);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = (GameObject)(Instantiate(stick, transform.position +
                transform.up * 1.5f, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        }
        if(Time.fixedTime >= 30)
        {
            SceneManager.LoadScene("level2", LoadSceneMode.Single);
        }
    }
}
