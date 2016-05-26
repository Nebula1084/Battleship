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

		Debug.Log ("Enter::Awake()");
	}
	
	void OnClick()
	{
		Debug.Log("NGUI button name :");
	}
}
