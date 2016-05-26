using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Enter::Start()");
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void Awake()
	{
		GameObject button = GameObject.Find("UI Root/Enter");
		UIEventListener.Get(button).onClick = ButtonClick;
		Debug.Log ("Enter::Awake()");
	}
	
	void ButtonClick(GameObject button)
	{
		Debug.Log("NGUI button name :"+button.name);
	}
}
