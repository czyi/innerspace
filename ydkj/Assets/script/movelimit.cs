using UnityEngine;
using System.Collections;

public class movelimit : MonoBehaviour {

	public int turnspeed=5;
	public int speed=5;
	public GameObject wall;

	private int count=0;

	// Use this for initialization
	void Start () {
		wall=GameObject.Find("allroom/barrier");
	}
	
	// Update is called once per frame
	void Update () 
	{
		int num;

		//左A右D
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			transform.Translate (-1, 0, 0, Space.Self);
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (1, 0, 0, Space.Self);
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			transform.Translate(1, 0, 0, Space.Self);
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (-1, 0, 0, Space.Self);
		}
		
		//前W后S
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			transform.Translate (0, 0, 1, Space.Self);
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (0, 0, -1, Space.Self);
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			transform.Translate (0, 0, -1, Space.Self);	
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (0, 0, 1, Space.Self);
		}

		//上下移动
		if(Input.GetKeyDown(KeyCode.Z))
		{
			transform.Translate(0, 1, 0, Space.Self);
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (0, -1, 0, Space.Self);
		}
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			transform.Translate (0, -1, 0, Space.Self);
			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100+(transform.position.z+4.5f)*10);
			if(Mathf.Abs(transform.position.x)>5||Mathf.Abs(transform.position.y)>5
			   ||Mathf.Abs(transform.position.z)>5||wall.GetComponent<bianli>().wall[num]==1)
				transform.Translate (0, 1, 0, Space.Self);
		}

		if(Input.GetKeyDown (KeyCode.F1))
			change2freemode();
		
		//左右转向
		if (Input.GetKeyDown (KeyCode.Q)) {
			//transform.Rotate (0, -90, 0, Space.Self);
			StartCoroutine (Funcleft ());
			//transform.FindChild("dir").RotateAround(transform.position, Space.Self, -90);
		}
		if(Input.GetKeyDown(KeyCode.E)){
			//transform.Rotate(0, 90, 0, Space.Self);
			StartCoroutine (Funcright ());
		}
		
		//上下转向
		if(Input.GetKeyDown(KeyCode.R)){
			//transform.Rotate(-90, 0, 0, Space.Self);
			StartCoroutine (Funcup ());
		}
		if(Input.GetKeyDown(KeyCode.F)){
			//transform.Rotate(90, 0, 0, Space.Self);
			StartCoroutine (Funcdown ());
		}
	}


	IEnumerator Funcleft ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, -6, 0, Space.Self);
			yield return new WaitForSeconds(0.03f);
		}
	}

	IEnumerator Funcright ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (0, 6, 0, Space.Self);
			yield return new WaitForSeconds(0.03f);
		}
	}
	IEnumerator Funcup ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (-6, 0, 0, Space.Self);
			yield return new WaitForSeconds(0.03f);
		}
	}
	IEnumerator Funcdown ()
	{
		for (int i=0; i<15; i++) {
			transform.Rotate (6, 0, 0, Space.Self);
			yield return new WaitForSeconds(0.03f);
		}
	}
	
	public void change2freemode()
	{
		Debug.Log("change2freemode");
		GetComponent<movelimit> ().enabled = false;
		GetComponent<movefree> ().enabled = true;
		GetComponent<mouse_look> ().enabled = true;
	}
}
