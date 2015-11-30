using UnityEngine;
using System.Collections;

public class achievedesguide : MonoBehaviour {

	public float[] des=new float[3];
	public float[] ori=new float[3];
	
	public float dd=0.1f;
	public GameObject desbox;
	public GameObject pass;
	public GameObject transguide, rotateguide, pushguide, limitguide, limitguide1;
	public GameObject inroom, outroom, inguide, outguide, passguide;

	// Use this for initialization
	void Start () {
		//des [0] = 0.5f; des [1] = -2.5f; des [2] = 0.5f;
		des [0] = desbox.GetComponent<Transform>().position.x;
		des [1] = desbox.GetComponent<Transform>().position.y;
		des [2] = desbox.GetComponent<Transform>().position.z;

		ori [0] = transform.FindChild("box").position.x; 
		ori [1] = transform.FindChild("box").position.y; 
		ori [2] = transform.FindChild("box").position.z;

		//desbox=GameObject.Find("desbox");

		pass.SetActive (false);
		transguide.SetActive(true);
		rotateguide.SetActive(false);
		pushguide.SetActive(false);
		limitguide.SetActive(false);
		limitguide1.SetActive(false);

		inroom.SetActive (true);
		outroom.SetActive (false);
		inguide.SetActive (false);
		outguide.SetActive (false);
		passguide.SetActive (false);
	}

	private int cw=0, cs=0, ca=0, cd=0, cz=0, cc=0;
	private int cq=0, ce=0, cr=0, cf=0, co=0, ci=0;
	private int cright=0, state=0, freeflag=0, cf1=0, cf2=0;

	// Update is called once per frame
	void Update () {
		float x=transform.FindChild("box").position.x;
		float y=transform.FindChild("box").position.y;
		float z=transform.FindChild("box").position.z;

//		Debug.Log("xyz,"+x+","+y+","+z);
//		Debug.Log("des,"+des[0]+","+-des[1]+","+des[2]);
//		Debug.Log(Mathf.Abs(x-des[0])+","+ Mathf.Abs(y-des[1])+","+Mathf.Abs(z-des[2]));

		if(Mathf.Abs(x-des[0])<dd && Mathf.Abs(y-des[1])<dd && Mathf.Abs(z-des[2])<dd)
		{//过关
			passguide.SetActive(false);
			pass.SetActive (true);
			//Debug.Log ("des");
		}  

		if(Input.GetKey(KeyCode.W)) cw=1;
		if(Input.GetKey(KeyCode.S)) cs=1;
		if(Input.GetKey(KeyCode.A)) ca=1;
		if(Input.GetKey(KeyCode.D)) cd=1;
		if(Input.GetKey(KeyCode.Z)) cz=1;
		if(Input.GetKey(KeyCode.C)) cc=1;

		if(Input.GetKey(KeyCode.Q)) cq=1;
		if(Input.GetKey(KeyCode.E)) ce=1;
		if(Input.GetKey(KeyCode.R)) cr=1;
		if(Input.GetKey(KeyCode.F)) cf=1;

		if (cw == 1 && cs == 1 && ca == 1 && cd == 1 && cz == 1 && cc == 1) 
		{//移动向导完成,开始旋转向导
			transguide.SetActive(false);
			rotateguide.SetActive(true);
			state=1;
		}

		if (Input.GetMouseButton (1)) cright = 1;

		if(cq==1 && ce ==1 && cr==1 && cf ==1 && cright == 1 && state == 1)
		{//旋转向导完成,开始推箱子向导
			rotateguide.SetActive(false);
			pushguide.SetActive(true);
			state=2;
		} 

		if((Mathf.Abs(x-ori[0])>dd || Mathf.Abs(y-ori[1])>dd || Mathf.Abs(z-ori[2])>dd) && state == 2)
		{//推箱子向导完成，开始室内外切换
			pushguide.SetActive(false);
			//limitguide.SetActive(true);
			outguide.SetActive(true);
			state=3;
		} 

		if (Input.GetKey (KeyCode.O)) 
		{//切换到房间外，摄像机位置？
			inroom.SetActive(false);
			//inroom.GetComponent<MeshRenderer>().enabled=true;
			//外部摄像机位置
			outroom.SetActive(true);
//			outroom.GetComponent<Transform>().position = 
//				new Vector3(inroom.GetComponent<Transform>().position.x+10f, 
//				            inroom.GetComponent<Transform>().position.y+10f, 
//				            inroom.GetComponent<Transform>().position.z+10f);
//			outroom.GetComponent<Transform>().rotation=inroom.GetComponent<Transform>().rotation;

			co=1;
		}

		if(co==1 && state==3)
		{//外切向导完成，开始内切向导
			outguide.SetActive(false);
			inguide.SetActive(true);
			state=4;
		}

		if (Input.GetKey (KeyCode.I)) {//切换到房间内
			//inroom.GetComponent<MeshRenderer>().enabled=false;
			inroom.SetActive(true);
			outroom.SetActive(false);
			ci=1;
		}

		if (ci == 1 && state == 4) 
		{//内切向导完成，开始限制模式向导
			inguide.SetActive(false);
			limitguide.SetActive(true);
			limitguide1.SetActive(true);
			state=5;
		}

		if (Input.GetKey (KeyCode.F1)) cf1 = 1;
		if (Input.GetKey (KeyCode.F2)) cf2 = 1;

		if (cf1 == 1 && cf2 == 1)
			freeflag = 1;;

		if (freeflag == 1 && state == 5) 
		{//模式向导完成，开始过关向导
			limitguide.SetActive(false);
			limitguide1.SetActive(false);
			passguide.SetActive(true);
			state=6;
		}
	}
	
	public void change2freemode()
	{
		freeflag = 1;
	}

	public void replay()
	{
		Application.LoadLevel("00gradelevel") ;
	}

	public void nextlevel()
	{
		Application.LoadLevel("01gravity") ;
	}


}



















