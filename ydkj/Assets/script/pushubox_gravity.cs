using UnityEngine;
using System.Collections;

public class pushubox_gravity : MonoBehaviour {

	public GameObject inroom, wall;
	public int num;

	private float gap=0.3f, c2c=0.9f, lc2c=1.1f;

	// Use this for initialization
	void Start () {
		//inroom = GameObject.Find ("1stperson");
		//wall=GameObject.Find("allroom/barrier");

		//wall array shuzu box 2
		num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100
		                     +(transform.position.z+4.5f)*10);
		wall.GetComponent<bianli> ().wall [num] = 2;

//		//gravity
//		while (transform.position.y > -4) 
//		{//不在最底层
//			if(wall.GetComponent<bianlinor1>().wall[num-100]!=0)
//				transform.Translate(0,-1,0);
//			else
//				break;
//			
//			wall.GetComponent<bianlinor1> ().wall [num] = 0;
//			wall.GetComponent<bianlinor1> ().wall [num] = 2;
//			num-=100;
//		}
	}
	
	// Update is called once per frame
//	void Update () {
//		//transform.Translate (1, 0, 0);
//		float dx = transform.position.x - inroom.transform.position.x;
//		float dy = transform.position.y - inroom.transform.position.y;
//		float dz = transform.position.z - inroom.transform.position.z;
//
//		num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//		                     +(transform.localPosition.z+4.5f)*10);
//
//		//中心离中心0.9以内
//		if ((dx*dx+dy*dy+dz*dz<0.5) && inroom.GetComponent<mouse_look> ().enabled == true)
//		{//freemode
//			if (Mathf.Abs (dx) >= Mathf.Abs (dy) & Mathf.Abs (dx) >= Mathf.Abs (dz)) {
//				if (dx >= 0)
//				{
//					if(transform.position.x < 4)
//					{
//						transform.Translate (1, 0, 0);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                     +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (-1, 0, 0);
//						inroom.GetComponent<Transform>().Translate(-gap,0,0,Space.World);
//					}
//				}
//				else{
//					if(transform.position.x > -4)
//					{
//						transform.Translate (-1, 0, 0);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                    +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (1, 0, 0);
//						inroom.GetComponent<Transform>().Translate(gap,0,0,Space.World);
//					}
//				}
//			} 
//			else if (Mathf.Abs (dy) >= Mathf.Abs (dz)) {
//				if (dy >= 0)
//				{
//					if(transform.position.y < 4)
//					{
//						transform.Translate (0, 1, 0);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                     +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (0, 1, 0);
//						inroom.GetComponent<Transform>().Translate(0,-gap,0,Space.World);
//					}
//				}
//				else{
//					if(transform.position.y > -4)
//					{
//						transform.Translate (0, -1, 0);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                     +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (0, -1, 0);
//						inroom.GetComponent<Transform>().Translate(0,gap,0,Space.World);
//					}
//				}
//			} 
//			else {
//				if (dz >= 0)
//				{
//					if(transform.position.z < 4)
//					{
//						transform.Translate (0, 0, 1, Space.World);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                     +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (0, 0, -1, Space.World);
//						inroom.GetComponent<Transform>().Translate(0,0,-gap,Space.World);
//					}
//				}
//				else{
//					if(transform.position.z > -4)
//					{
//						transform.Translate (0, 0, -1, Space.World);
//						num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
//						                     +(transform.localPosition.z+4.5f)*10);
//					}
//					if(wall.GetComponent<bianlinor1>().wall[num]!=0)
//					{
//						transform.Translate (0, 0, 1, Space.World);
//						inroom.GetComponent<Transform>().Translate(0,0,gap,Space.World);
//					}
//				}
//			}
//		}
//
//		wall.GetComponent<bianlinor1> ().wall [num] = 0;
//
//		num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100
//		                     +(transform.position.z+4.5f)*10);
//		wall.GetComponent<bianlinor1> ().wall [num] = 2;
//
//		//int prenum = num;
//
////		//gravity
////		while (transform.position.y > -4) 
////		{//不在最底层
////			if(wall.GetComponent<bianlinor1>().wall[num-100]!=0)
////				transform.Translate(0,-1,0);
////			else
////				break;
////
////			wall.GetComponent<bianlinor1> ().wall [num] = 0;
////			wall.GetComponent<bianlinor1> ().wall [num] = 2;
////			num-=100;
////		}
//			
//	}

//	public int limitmove(float lx, float ly, float lz)
//	{
//		int dx = Mathf.RoundToInt (transform.position.x - lx);
//		int dy = Mathf.RoundToInt (transform.position.y - ly);
//		int dz = Mathf.RoundToInt (transform.position.z - lz);
//
//		if (dx * dx + dy * dy + dz * dz > 1)
//			return 0;
//		else 
//		{
//			if(dx>0)
//			{//x
//
//			}
//			else if(dx<0)
//			{
//
//			}
//
//		}
//
//
//
//		if (inroom.GetComponent<mouse_look> ().enabled == false) 
//		{//limitmode
//			if (Mathf.Abs (dx) < lc2c) {
//				if (dx >= 0)
//				{
//					if(transform.position.x < 4 && wall.GetComponent<bianli>().wall[num+1]==0)
//						transform.Translate (1, 0, 0);
//					else
//						inroom.GetComponent<Transform>().Translate(-gap,0,0,Space.World);
//				}
//				else{
//					if(transform.position.x > -4 && wall.GetComponent<bianli>().wall[num-1]==0)
//						transform.Translate (-1, 0, 0);
//					else
//						inroom.GetComponent<Transform>().Translate(gap,0,0,Space.World);
//				}
//			}
//
//			if (Mathf.Abs (dy) < lc2c) {
//				if (dy >= 0)
//				{
//					if(transform.position.y < 4 && wall.GetComponent<bianli>().wall[num+100]==0)
//						transform.Translate (0, 1, 0);
//					else
//						inroom.GetComponent<Transform>().Translate(0,-gap,0,Space.World);
//				}
//				else
//				{
//					if(transform.position.y > -4 && wall.GetComponent<bianli>().wall[num-100]==0)
//						transform.Translate (0, -1, 0);
//					else
//						inroom.GetComponent<Transform>().Translate(0,gap,0,Space.World);
//				}
//			} 
//
//			if (Mathf.Abs (dz) < lc2c) {
//				if (dz >= 0) 
//				{
//					if(transform.position.z < 4 && wall.GetComponent<bianli>().wall[num+10]==0)
//						transform.Translate (0, 0, 1);
//					else
//						inroom.GetComponent<Transform>().Translate(0,0,-gap,Space.World);
//				}
//				else
//				{
//					if(transform.position.z > -4 && wall.GetComponent<bianli>().wall[num-10]==0)
//						transform.Translate (0, 0, -1);
//					else
//						inroom.GetComponent<Transform>().Translate(0,0,gap,Space.World);
//				}
//			}
//
//		}
//	}

	public int freemovepush(float fx, float fy, float fz)
	{
		float dx = transform.position.x - fx;
		float dy = transform.position.y - fy;
		float dz = transform.position.z - fz;
		int flag = 1;

		int prenum=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
		                     +(transform.localPosition.z+4.5f)*10);

		if (Mathf.Abs (dx) >= Mathf.Abs (dy) & Mathf.Abs (dx) >= Mathf.Abs (dz)) {
			if (dx >= 0)
			{
				if(transform.position.x < 4)
				{
					transform.Translate (1, 0, 0,Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                     +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (-1, 0, 0,Space.World);
					inroom.GetComponent<Transform>().Translate(-gap,0,0,Space.World);
				}
			}
			else{
				if(transform.position.x > -4)
				{
					transform.Translate (-1, 0, 0,Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                    +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (1, 0, 0,Space.World);
					inroom.GetComponent<Transform>().Translate(gap,0,0,Space.World);
				}
			}
		} 
		else if (Mathf.Abs (dy) >= Mathf.Abs (dz)) {
			if (dy >= 0)
			{
				if(transform.position.y < 4)
				{
					transform.Translate (0, 1, 0,Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                     +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (0, 1, 0,Space.World);
					inroom.GetComponent<Transform>().Translate(0,-gap,0,Space.World);
				}
			}
			else{
				if(transform.position.y > -4)
				{
					transform.Translate (0, -1, 0,Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                     +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (0, -1, 0,Space.World);
					inroom.GetComponent<Transform>().Translate(0,gap,0,Space.World);
				}
			}
		} 
		else {
			if (dz >= 0)
			{
				if(transform.position.z < 4)
				{
					transform.Translate (0, 0, 1, Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                     +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (0, 0, -1, Space.World);
					inroom.GetComponent<Transform>().Translate(0,0,-gap,Space.World);
				}
			}
			else{
				if(transform.position.z > -4)
				{
					transform.Translate (0, 0, -1, Space.World);
					num=Mathf.RoundToInt(transform.localPosition.x+4.5f+(transform.localPosition.y+4.5f)*100
					                     +(transform.localPosition.z+4.5f)*10);
				}
				if(wall.GetComponent<bianli>().wall[num]!=0)
				{
					flag=0;
					transform.Translate (0, 0, 1, Space.World);
					inroom.GetComponent<Transform>().Translate(0,0,gap,Space.World);
				}
			}
		}

		wall.GetComponent<bianli> ().wall [prenum] = 0;

		num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100
		                     +(transform.position.z+4.5f)*10);
		wall.GetComponent<bianli> ().wall [num] = 2;

		return flag;
	}



	public void adjust()
	{
		int intex = Mathf.RoundToInt(transform.position.x + 0.5f);
		int intey = Mathf.RoundToInt(transform.position.y + 0.5f);
		int intez = Mathf.RoundToInt(transform.position.z + 0.5f);
		transform.position = new Vector3 (intex-0.5f, intey, intez-0.5f);
		
		int totax = Mathf.RoundToInt (transform.localEulerAngles.x / 90) * 90;
		int totay = Mathf.RoundToInt (transform.localEulerAngles.y / 90) * 90;
		int totaz = Mathf.RoundToInt (transform.localEulerAngles.z / 90) * 90;
		transform.localEulerAngles = new Vector3(totax, totay, totaz);  
	}
}
