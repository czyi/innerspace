using UnityEngine;
using System.Collections;

public class changeview : MonoBehaviour {

	public GameObject inroom, outroom;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//房间内外切换
		if (Input.GetKey (KeyCode.O)) 
		{//切换到房间外
			inroom.SetActive(false);
			outroom.SetActive(true);
		}
		if (Input.GetKey (KeyCode.I)) 
		{//切换到房间外
			inroom.SetActive (true);
			outroom.SetActive (false);
		}
	
	}
}
