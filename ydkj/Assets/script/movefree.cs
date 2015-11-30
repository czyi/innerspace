using UnityEngine;
using System.Collections;

public class movefree : MonoBehaviour {
	
	public int speed=3;
	public int turnspeed=45;

	// Update is called once per frame
	void Update () {

		//左右移动,ad
		float x=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		transform.Translate(x,0,0);
		
		//前W后S
		if(Input.GetKey(KeyCode.W))
			transform.Translate(0, 0, speed*Time.deltaTime, Space.Self);
		if(Input.GetKey(KeyCode.S))
			transform.Translate(0, 0, -speed*Time.deltaTime, Space.Self);	
		
		//左右旋转角度
		if(Input.GetKey(KeyCode.Q))
			transform.Rotate(0, -turnspeed*Time.deltaTime, 0, Space.Self);
		if(Input.GetKey(KeyCode.E))
			transform.Rotate(0, turnspeed*Time.deltaTime, 0, Space.Self);

		//上下旋转角度
		if(Input.GetKey(KeyCode.R))
			transform.Rotate(-turnspeed*Time.deltaTime, 0, 0, Space.Self);
		if(Input.GetKey(KeyCode.F))
			transform.Rotate(turnspeed*Time.deltaTime, 0, 0, Space.Self);	
		
		//上下移动
		if(Input.GetKey(KeyCode.Z))
			transform.Translate(0, speed*Time.deltaTime, 0, Space.Self);
		if(Input.GetKey(KeyCode.C))
			transform.Translate(0, -speed*Time.deltaTime, 0, Space.Self);

		//改成六方向模式移动
		if (Input.GetKeyDown (KeyCode.F2))
			change2limitmode ();

		//返回选择菜单
		if (Input.GetKeyDown (KeyCode.F10))
			Application.LoadLevel("choose_level");
	}

	public void change2limitmode()
	{//变成六方向模式移动
		Debug.Log ("change2limitmode");

		int intex = Mathf.RoundToInt(transform.position.x + 0.5f);
		int intey = Mathf.RoundToInt(transform.position.y + 0.5f);
		int intez = Mathf.RoundToInt(transform.position.z + 0.5f);
		transform.Translate (intex - 0.5f - transform.position.x, intey - 0.5f - transform.position.y, intez - 0.5f - transform.position.z);

		int totax = Mathf.RoundToInt (transform.localEulerAngles.x / 90) * 90;
		int totay = Mathf.RoundToInt (transform.localEulerAngles.y / 90) * 90;
		int totaz = Mathf.RoundToInt (transform.localEulerAngles.z / 90) * 90;
		transform.localEulerAngles = new Vector3(totax, totay, totaz);   

		GetComponent<movelimit> ().enabled = true;
		GetComponent<movefree> ().enabled = false;
		GetComponent<mouse_look> ().enabled = false;
	}
}









