using UnityEngine;
using System.Collections;

public class roomrotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.U)){
			//transform.Rotate(-90, 0, 0, Space.Self);
			correct();
			StartCoroutine (Funcup ());
		}
		if(Input.GetKeyDown(KeyCode.J)){
			//transform.Rotate(90, 0, 0, Space.Self);
			correct();
			StartCoroutine (Funcdown ());
		}
		if(Input.GetKeyDown(KeyCode.H)){
			//transform.Rotate(-90, 0, 0, Space.Self);
			StartCoroutine (Funcleft ());
		}
		if(Input.GetKeyDown(KeyCode.K)){
			//transform.Rotate(90, 0, 0, Space.Self);
			StartCoroutine (Funcright ());
		}
		if(Input.GetKeyDown(KeyCode.N)){
			//transform.Rotate(-90, 0, 0, Space.Self);
			correct();
			StartCoroutine (Funcrotateleft ());
		}
		if(Input.GetKeyDown(KeyCode.M)){
			//transform.Rotate(90, 0, 0, Space.Self);
			correct();
			StartCoroutine (Funcrotateright ());
		}
		
		//		if (Input.GetKeyDown (KeyCode.Q)) {
//			transform.Rotate (0, -90, 0, Space.Self);
//			//transform.FindChild("dir").RotateAround(transform.position, Space.Self, -90);
//		}
//		if(Input.GetKeyDown(KeyCode.E)){
//			transform.Rotate(0, 90, 0, Space.Self);
//		}
//		if(Input.GetKeyDown(KeyCode.R)){
//			//transform.Rotate(-90, 0, 0, Space.Self);
//			StartCoroutine (Funcdown ());
//		}
//		if(Input.GetKeyDown(KeyCode.F)){
//			transform.Rotate(90, 0, 0, Space.Self);
//		}
//		
//		if(Input.GetKeyDown(KeyCode.UpArrow)){
//			transform.Rotate(-90, 0, 0, Space.Self);
//		}
//		if(Input.GetKeyDown(KeyCode.DownArrow)){
//			transform.Rotate(90, 0, 0, Space.Self);
//		}
//		if(Input.GetKeyDown(KeyCode.LeftArrow)){
//			transform.Rotate(-90, 0, 0, Space.Self);
//		}
//		if(Input.GetKeyDown(KeyCode.RightArrow)){
//			transform.Rotate(90, 0, 0, Space.Self);
//		}
	}

	private void correct()
	{
		GameObject.Find("allroom/allbox/box0").GetComponent<pushubox_gravity>().adjust();
		GameObject.Find("allroom/allbox/box1").GetComponent<pushubox_gravity>().adjust();
		GameObject.Find("allroom/allbox/box2").GetComponent<pushubox_gravity>().adjust();
		GameObject.Find("allroom/allbox/box3").GetComponent<pushubox_gravity>().adjust();
	}

	IEnumerator Funcup ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (6, 0, 0, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}
	IEnumerator Funcdown ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (-6, 0, 0, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}

	IEnumerator Funcleft ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, -6, 0, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}
	
	IEnumerator Funcright ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, 6, 0, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}

	IEnumerator Funcrotateleft ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, 0, 6, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}

	IEnumerator Funcrotateright ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, 0, -6, Space.World);
			yield return new WaitForSeconds(0.03f);
		}
	}
}




