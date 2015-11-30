using UnityEngine;
using System.Collections;

public class achdesfourguide : MonoBehaviour {
	
	public GameObject[] desbox=new GameObject[4];
	public GameObject[] curbox=new GameObject[4];
	public GameObject pass, dir, inroom, outroom, guide;
	
	private int[] ifachi=new int[4];
	private float dd=0.1f;
	
	// Use this for initialization
	void Start () {
		ifachi [0] = 0; ifachi [1] = 0;
		ifachi [2] = 0; ifachi [3] = 0;
		pass.SetActive (false);
		
		guide=GameObject.Find("Canvas/guide");
		inroom.SetActive (true);
		outroom.SetActive (false);
		//Debug.Log ("ifachi, "+ifachi [0] + ", " + ifachi [1] + ", " + ifachi [2] + ", " + ifachi [3]);
	}
	
	// Update is called once per frame
	void Update () {
		//四个箱子在的位置也为1
		
		
		//判断是否通关
		for (int desnum=0; desnum<4; desnum++) 
		{
			for(int boxnum=0;boxnum<4;boxnum++)
			{
				if(desbox[desnum].GetComponent<Transform>().position==curbox[boxnum].GetComponent<Transform>().position)
					ifachi[desnum]=1;
			}
		}
		
		Debug.Log ("ifachi, "+ifachi [0] + ", " + ifachi [1] + ", " + ifachi [2] + ", " + ifachi [3]);
		if (ifachi [0] == 1 && ifachi [1] == 1 && ifachi [2] == 1 && ifachi [3] == 1) 
		{	
			Debug.Log("pass level!");
			pass.SetActive (true);
		}
		
		//房间内外切换
		if (Input.GetKey (KeyCode.O)) 
		{//切换到房间外
			inroom.SetActive(false);
			outroom.SetActive(true);
			guide.SetActive(false);
		}
		if (Input.GetKey (KeyCode.I)) 
		{//切换到房间外
			inroom.SetActive(true);
			outroom.SetActive(false);
		}
		
	}
	
	public void replay01normal()
	{
		Application.LoadLevel("01normal01");
	}
	
	public void change2gravity1()
	{
		Application.LoadLevel("04gravity1");
	}
}



















