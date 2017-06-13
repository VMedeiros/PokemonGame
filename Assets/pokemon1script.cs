using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pokemon1script : MonoBehaviour {

	public Button attackButton1;
	public GameObject hose;
	// Use this for initialization
	void Start () {
		attackButton1.onClick.AddListener (attackButton1Down);
		hose.transform.FindChild ("Smoke").gameObject.SetActive(false);
	}
	IEnumerator Wait(){
		hose.transform.FindChild ("Smoke").gameObject.SetActive(true);
		yield return new WaitForSeconds (1);
		hose.transform.FindChild ("Smoke").gameObject.SetActive(false);
	}

	void attackButton1Down(){
		StartCoroutine (Wait ());
	}
	// Update is called once per frame
	void Update () {
		
	}
}
