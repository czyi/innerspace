using UnityEngine;
using System.Collections;

public class hideguide : MonoBehaviour {

	public GameObject guide;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.O))
			guide.SetActive (false);
	
	}
}
