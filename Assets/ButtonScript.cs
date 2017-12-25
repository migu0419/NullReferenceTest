using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public GameObject myObject;
	public int count;
	public AudioClip audioClip;

	void Awake () {
		myObject = GameObject.Find ("GameObject");
		ShowName ();
		AddCount ();
		myObject.GetComponent< Button> ().enabled = false;
		if (audioClip != null) {
			Debug.Log (audioClip.length);
		} else {
			Debug.Log ("Null!");
		}
		Debug.Log ("ほげほげ");
	}
	

	public void ShowName(){
		Debug.Log (myObject.name);
	}

	public void AddCount(){
		count++;
		Debug.Log (count);			
	}
}
