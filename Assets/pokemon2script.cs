using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pokemon2script : MonoBehaviour {

	public Button attackButton2;
	public GameObject hose;
	// Use this for initialization
	void Start () {
		attackButton2.onClick.AddListener (attackButton2Down);
		hose.transform.FindChild ("Glow").gameObject.SetActive(false);
	}
	IEnumerator Wait(){
		hose.transform.FindChild ("Glow").gameObject.SetActive(true);
		yield return new WaitForSeconds (1);
		hose.transform.FindChild ("Glow").gameObject.SetActive(false);
	}

	void attackButton2Down(){
		StartCoroutine (Wait ());
	}
	// Update is called once per frame
	void Update () {
		
	}
}