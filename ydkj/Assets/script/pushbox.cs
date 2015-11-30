using UnityEngine;
using System.Collections;

public class pushbox : MonoBehaviour {
	
	public GameObject inroom;
	public GameObject dir;
	public GameObject wall;

	void Start()
	{
		wall=GameObject.Find("allroom/barrier");
	}

	void OnTriggerEnter(Collider otherobject)
	{
		if(inroom.GetComponent<mouse_look>().enabled == true)
		{//freemode
			int num;
			float gap=0.3f;

			//transform.Translate (1, 0, 0);
			float dx = transform.position.x - otherobject.transform.position.x;
			float dy = transform.position.y - otherobject.transform.position.y;
			float dz = transform.position.z - otherobject.transform.position.z;

			num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100
			                     +(transform.position.z+4.5f)*10);
			if (Mathf.Abs (dx) >= Mathf.Abs (dy) & Mathf.Abs (dx) >= Mathf.Abs (dz)) {
				if (dx >= 0)
				{
					if(transform.position.x < 4 && wall.GetComponent<bianli>().wall[num+1]==0)
						transform.Translate (1, 0, 0);
					else
						otherobject.GetComponent<Transform>().Translate(-gap,0,0,Space.World);
				}
				else{
					if(transform.position.x > -4 && wall.GetComponent<bianli>().wall[num-1]==0)
						transform.Translate (-1, 0, 0);
					else
						otherobject.GetComponent<Transform>().Translate(gap,0,0,Space.World);
				}
			} 
			else if (Mathf.Abs (dy) >= Mathf.Abs (dz)) {
				if (dy >= 0)
				{
					if(transform.position.y < 4 && wall.GetComponent<bianli>().wall[num+100]==0)
						transform.Translate (0, 1, 0);
					else
						otherobject.GetComponent<Transform>().Translate(0,-gap,0,Space.World);
				}
				else
				{
					if(transform.position.y > -4 && wall.GetComponent<bianli>().wall[num-100]==0)
						transform.Translate (0, -1, 0);
					else
						otherobject.GetComponent<Transform>().Translate(0,gap,0,Space.World);
				}
			} 
			else {
				if (dz >= 0) 
				{
					if(transform.position.z < 4 && wall.GetComponent<bianli>().wall[num+10]==0)
						transform.Translate (0, 0, 1);
					else
						otherobject.GetComponent<Transform>().Translate(0,0,-gap,Space.World);
				}
				else
				{
					if(transform.position.z > -4 && wall.GetComponent<bianli>().wall[num-10]==0)
						transform.Translate (0, 0, -1);
					else
						otherobject.GetComponent<Transform>().Translate(0,0,gap,Space.World);
				}
			}
		}
	}

	void OnTriggerStay(Collider otherobject)
	{
		if(inroom.GetComponent<mouse_look>().enabled == false)
		{
			int num=Mathf.RoundToInt(transform.position.x+4.5f+(transform.position.y+4.5f)*100
			                         +(transform.position.z+4.5f)*10);

			float dx=dir.GetComponent<Transform>().position.x-transform.position.x;
			float dy=dir.GetComponent<Transform>().position.y-transform.position.y;
			float dz=dir.GetComponent<Transform>().position.z-transform.position.z;

			Debug.Log("dxy, "+dx+", "+dy+", "+dz);
			int edge=4;

			if(dx>0.05)
			{
				if(transform.position.x < edge && wall.GetComponent<bianlinor>().wall[num+1]==0)
					transform.Translate (1, 0, 0, Space.World);
				else
					otherobject.transform.Translate(-1, 0, 0, Space.World);
			}
			else if(dx<-0.05)
			{
				if(transform.position.x > -edge && wall.GetComponent<bianlinor>().wall[num-1]==0)
					transform.Translate (-1, 0, 0, Space.World);
				else
					otherobject.transform.Translate(1, 0, 0, Space.World);
			}
			
			if(dy>0.05)
			{
				if(transform.position.y > -edge && wall.GetComponent<bianlinor>().wall[num+100]==0)
					transform.Translate (0, 1, 0, Space.World);
				else
					otherobject.transform.Translate(0, -1, 0, Space.World);
			}
			else if(dy<-0.05)
			{
				if(transform.position.y < edge && wall.GetComponent<bianlinor>().wall[num-100]==0)
					transform.Translate (0, -1, 0, Space.World);
				else
					otherobject.transform.Translate(0, 1, 0, Space.World);
			}
			
			if(dz>0.05)
			{
				if(transform.position.z < edge && wall.GetComponent<bianlinor>().wall[num+10]==0)
					transform.Translate (0, 0, 1, Space.World);
				else
					otherobject.transform.Translate(0, 0, -1, Space.World);
			}
			else if(dz<-0.05)
			{
				if(transform.position.z > -edge && wall.GetComponent<bianlinor>().wall[num-10]==0)
					transform.Translate (0, 0, -1, Space.World);
				else
					otherobject.transform.Translate(0, 0, 1, Space.World);
			}

			//调整玩家位置
			int intex = Mathf.RoundToInt(otherobject.transform.position.x + 0.5f);
			int intey = Mathf.RoundToInt(otherobject.transform.position.y + 0.5f);
			int intez = Mathf.RoundToInt(otherobject.transform.position.z + 0.5f);
			otherobject.transform.Translate (intex - 0.5f - otherobject.transform.position.x,
			     intey - 0.5f - otherobject.transform.position.y, intez - 0.5f - otherobject.transform.position.z);
			
			int totax = Mathf.RoundToInt (otherobject.transform.localEulerAngles.x / 90) * 90;
			int totay = Mathf.RoundToInt (otherobject.transform.localEulerAngles.y / 90) * 90;
			int totaz = Mathf.RoundToInt (otherobject.transform.localEulerAngles.z / 90) * 90;
			otherobject.transform.localEulerAngles = new Vector3(totax, totay, totaz);  
		}
	}
}
















