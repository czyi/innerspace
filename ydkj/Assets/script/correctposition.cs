using UnityEngine;
using System.Collections;

public class correctposition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
