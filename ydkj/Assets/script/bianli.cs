using UnityEngine;
using System.Collections;

public class bianli : MonoBehaviour {
	
	public int[] wall = new int[1000];

	// Use this for initialization
	void Start () {
		int num=0;
		wall [999] = 999;
		Debug.Log (wall [999]);

		foreach (Transform firstchild in transform)
		{
			//Debug.Log(firstchild.gameObject.name);
			foreach(Transform secondchild in firstchild)
			{
				//Debug.Log(secondchild.gameObject.name);
				foreach(Transform thirdchild in secondchild)
				{
					//Debug.Log(thirdchild.gameObject.name);
					num=Mathf.RoundToInt(thirdchild.position.x+4.5f+(thirdchild.position.y+4.5f)*100+
					                     (thirdchild.position.z+4.5f)*10);
					//Debug.Log("num is "+num);
					//if(num>=0 && num<1000)
						wall[num]=1;
				}
			}
		}

//		int zeronum = 0, onenum = 0;
//		for (int i=0; i<1000; i++) {
//			if(wall[i]==0)
//				zeronum++;
//			if(wall[i]==1)
//				onenum++;
// 		}
//
//		Debug.Log ("zero num is " + zeronum);
//		Debug.Log ("one num is " + onenum);
	
	}
	
	// Update is called once per frame
	void Update () {





	
	}
}
