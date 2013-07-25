using UnityEngine;
using System.Collections;

public class BGMLibraly : MonoBehaviour {
	
	AudioClip BGM1;
	AudioClip BGM2;
	AudioClip BGM3;

	AudioSource audioSourceBGM1;
	AudioSource audioSourceBGM2;
	AudioSource audioSourceBGM3;

	
	enum SoundSelect {
		BGM1,
		BGM2,
		BGM3,
		OFF,
		iTunes
	}
	
	void Awake() {
	
		BGM1 = Resources.Load("Sound/BGM1",typeof(AudioClip)) as AudioClip;
		BGM2 = Resources.Load("Sound/BGM2",typeof(AudioClip)) as AudioClip;
		BGM3 = Resources.Load("Sound/BGM3",typeof(AudioClip)) as AudioClip;
		
		
		audioSourceBGM1 = gameObject.AddComponent<AudioSource>();
		audioSourceBGM2 = gameObject.AddComponent<AudioSource>();
		audioSourceBGM3 = gameObject.AddComponent<AudioSource>();
	
	}
	

	// Use this for initialization
	void Start () {
		
		GameObject.DontDestroyOnLoad(this.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//if
	
	}
	
	public void PlayBGM1()
	{
		audioSourceBGM1.clip = BGM1;
		audioSourceBGM1.loop = true;
		audioSourceBGM1.Play();
		
	}

	public void PlayBGM2()
	{
		
	}

	public void PlayBGM3()
	{
		
	}

	public void OFFSound()
	{
		
	}
	
	public void iTunes()
	{
		
	}

}
