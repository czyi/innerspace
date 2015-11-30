using UnityEngine;
using System.Collections;

public class mouse_look : MonoBehaviour {
	
	//方向灵敏度  
	public float sensitivityX = 2F;   
	public float sensitivityY = 2F;   

	void Update ()  
	{  
		if (Input.GetMouseButton (1)) 
		{
			//根据鼠标移动的快慢(增量), 获得相机左右旋转的角度(处理X)  
			float rotationX = Input.GetAxis("Mouse X") * sensitivityX;    
			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
   
			transform.Rotate(-rotationY, rotationX, 0);
		}	 
	}  
	
	void Start ()  
	{  
		// Make the rigid body not change rotation  
		if (GetComponent<Rigidbody>())  
			GetComponent<Rigidbody>().freezeRotation = true;  
	}  




}