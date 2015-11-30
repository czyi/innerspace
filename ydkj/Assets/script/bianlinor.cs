using UnityEngine;
using System.Collections;

public class bianlinor : MonoBehaviour {

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
				//Debug.Log(thirdchild.gameObject.name);
				num=Mathf.RoundToInt(secondchild.position.x+4.5f+(secondchild.position.y+4.5f)*100+
				                     (secondchild.position.z+4.5f)*10);
				//Debug.Log("num is "+num);
				//if(num>=0 && num<1000)
				wall[num]=1;
			}
		}		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
