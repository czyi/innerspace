using UnityEngine;
using System.Collections;

public class achdesone : MonoBehaviour {

	public GameObject desbox, pass;
	public GameObject inroom, outroom;

	private float dd=0.1f;
	private float[] des = new float[3];

	// Use this for initialization
	void Start () {
		pass.SetActive (false);
		inroom.SetActive (true);
		outroom.SetActive (false);

		des [0] = desbox.GetComponent<Transform>().position.x;
		des [1] = desbox.GetComponent<Transform>().position.y;
		des [2] = desbox.GetComponent<Transform>().position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(transform.position.x-des[0])<dd && Mathf.Abs(transform.position.y-des[1])<dd 
		   && Mathf.Abs(transform.position.z-des[2])<dd)
		{//过关
			pass.SetActive (true);
			//Debug.Log ("des");
		}  

		//房间内外切换
		if (Input.GetKey (KeyCode.O)) 
		{//切换到房间外
			inroom.SetActive(false);
			outroom.SetActive(true);
		}
		if (Input.GetKey (KeyCode.I)) 
		{//切换到房间外
			inroom.SetActive(true);
			outroom.SetActive(false);
		}
	}

	public void replay()
	{
		Application.LoadLevel("box");
	}


}
