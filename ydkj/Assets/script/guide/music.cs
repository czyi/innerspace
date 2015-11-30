//using UnityEngine;
//using System.Collections;
//
//public class music : MonoBehaviour {
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//
//	private static AudioManager instance = null;
//	
//	public AudioSource audioMgr;
//	
//	private AudioClip ac;
//	private string curMusicName = "";
//	
//	public static AudioManager Instance
//	{
//		get
//		{ 
//			return instance;
//		}
//	}
//	
//	void Awake()
//	{
//		if (instance != null && instance != this)
//		{
//			Destroy(this.gameObject);
//		}
//		else
//		{
//			instance = this;
//		}
//		
//		DontDestroyOnLoad(this.gameObject);
//	}
//	
//	public void  Play(string fileName)
//	{
//		if (!fileName.Equals(curMusicName))
//		{
//			ac = Resources.Load("Audio/"+fileName) as AudioClip;
//			audioMgr.clip = ac;
//			audioMgr.Play();
//			curMusicName = fileName;
//		}
//	}
//	
//	public void Stop()
//	{
//		audioMgr.Stop();
//		curMusicName = "";
//		Debug.Log("Stop background music");
//	}
//}
