using UnityEngine;
using System.Collections;

public class SoundLiblary : MonoBehaviour {

		AudioClip BGM01;
		AudioClip BGM02;
		AudioClip BGM03;
		AudioClip BGM04;
		AudioClip BGM05;
		AudioClip BGM06;

		AudioClip SE01;
		AudioClip SE02;
		AudioClip SE03;
		AudioClip SE04;
		AudioClip SE05;
		AudioClip SE06;
		AudioClip SE07;
		AudioClip SE08;
		AudioClip SE09;

		AudioClip CAR01;
		AudioClip CAR02;
		AudioClip CAR03;
		AudioClip CAR04;
		AudioClip CAR05;
		AudioClip CAR06;


		AudioSource audiosourceBGM;

		AudioSource audiosourceSE01;
		AudioSource audiosourceSE02;
		AudioSource audiosourceSE03;
		AudioSource audiosourceSE04;
		AudioSource audiosourceSE05;
		AudioSource audiosourceSE06;
		AudioSource audiosourceSE07;
		AudioSource audiosourceSE08;
		AudioSource audiosourceSE09;

		AudioSource audiosourceCAR01;
		AudioSource audiosourceCAR02;
		AudioSource audiosourceCAR03;
		AudioSource audiosourceCAR04;
		AudioSource audiosourceCAR05;
		AudioSource audiosourceCAR06;

	void Awake(){
		BGM01 = Resources.Load("Sound/BGM01",typeof(AudioClip)) as AudioClip;
		BGM02 = Resources.Load("Sound/BGM02",typeof(AudioClip)) as AudioClip;
		BGM03 = Resources.Load("Sound/BGM03",typeof(AudioClip)) as AudioClip;
		BGM04 = Resources.Load("Sound/BGM04",typeof(AudioClip)) as AudioClip;
		BGM05 = Resources.Load("Sound/BGM05",typeof(AudioClip)) as AudioClip;
		BGM06 = Resources.Load("Sound/BGM06",typeof(AudioClip)) as AudioClip;
		SE01 = Resources.Load("Sound/SE01",typeof(AudioClip)) as AudioClip;
		SE02 = Resources.Load("Sound/SE02",typeof(AudioClip)) as AudioClip;
		SE03 = Resources.Load("Sound/SE03",typeof(AudioClip)) as AudioClip;
		SE04 = Resources.Load("Sound/SE04",typeof(AudioClip)) as AudioClip;
		SE05 = Resources.Load("Sound/SE05",typeof(AudioClip)) as AudioClip;
		SE06 = Resources.Load("Sound/SE06",typeof(AudioClip)) as AudioClip;
		SE07 = Resources.Load("Sound/SE07",typeof(AudioClip)) as AudioClip;
		SE08 = Resources.Load("Sound/SE08",typeof(AudioClip)) as AudioClip;
		SE09 = Resources.Load("Sound/SE09",typeof(AudioClip)) as AudioClip;
		CAR01 = Resources.Load("Sound/CAR01",typeof(AudioClip)) as AudioClip;
		CAR02 = Resources.Load("Sound/CAR02",typeof(AudioClip)) as AudioClip;
		CAR03 = Resources.Load("Sound/CAR03",typeof(AudioClip)) as AudioClip;
		CAR04 = Resources.Load("Sound/CAR04",typeof(AudioClip)) as AudioClip;
		CAR05 = Resources.Load("Sound/CAR05",typeof(AudioClip)) as AudioClip;
		CAR06 = Resources.Load("Sound/CAR06",typeof(AudioClip)) as AudioClip;

		audiosourceBGM = gameObject.AddComponent<AudioSource>();
		audiosourceBGM.clip = BGM01;

		audiosourceSE01 = gameObject.AddComponent<AudioSource>();
		audiosourceSE02 = gameObject.AddComponent<AudioSource>();
		audiosourceSE03 = gameObject.AddComponent<AudioSource>();
		audiosourceSE04 = gameObject.AddComponent<AudioSource>();
		audiosourceSE05 = gameObject.AddComponent<AudioSource>();
		audiosourceSE06 = gameObject.AddComponent<AudioSource>();
		audiosourceSE07 = gameObject.AddComponent<AudioSource>();
		audiosourceSE08 = gameObject.AddComponent<AudioSource>();
		audiosourceSE09 = gameObject.AddComponent<AudioSource>();

		audiosourceCAR01 = gameObject.AddComponent<AudioSource>();
		audiosourceCAR02 = gameObject.AddComponent<AudioSource>();
		audiosourceCAR03 = gameObject.AddComponent<AudioSource>();
		audiosourceCAR04 = gameObject.AddComponent<AudioSource>();
		audiosourceCAR05 = gameObject.AddComponent<AudioSource>();
		audiosourceCAR06 = gameObject.AddComponent<AudioSource>();


	}

	// Use this for initialization
	void Start () {
	GameObject.DontDestroyOnLoad(this.gameObject);
	audiosourceBGM.clip = BGM01;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayBGM01(float vol)
	{
		audiosourceBGM.clip = BGM01;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlayBGM02(float vol)
	{
		audiosourceBGM.clip = BGM02;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlayBGM03(float vol)
	{
		audiosourceBGM.clip = BGM03;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlayBGM04(float vol)
	{
		audiosourceBGM.clip = BGM04;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlayBGM05(float vol)
	{
		audiosourceBGM.clip = BGM05;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlayBGM06(float vol)
	{
		audiosourceBGM.clip = BGM06;
		audiosourceBGM.loop = true;
		audiosourceBGM.Play();
	}
	public void PlaySE01(float vol)
	{
		audiosourceSE01.clip = SE01;
		audiosourceSE01.Play();
	}
	public void PlaySE02(float vol)
	{
		audiosourceSE02.clip = SE02;
		audiosourceSE02.Play();
	}
	public void PlaySE03(float vol)
	{
		audiosourceSE03.clip = SE03;
		audiosourceSE03.Play();
	}
	public void PlaySE04(float vol)
	{
		audiosourceSE04.clip = SE04;
		audiosourceSE04.Play();
	}
	public void PlaySE05(float vol)
	{
		audiosourceSE05.clip = SE05;
		audiosourceSE05.Play();
	}
	public void PlaySE06(float vol)
	{
		audiosourceSE06.clip = SE06;
		audiosourceSE06.Play();
	}
	public void PlaySE07(float vol)
	{
		audiosourceSE07.clip = SE07;
		audiosourceSE07.Play();
	}
	public void PlaySE08(float vol)
	{
		audiosourceSE08.clip = SE08;
		audiosourceSE08.Play();
	}
	public void PlaySE09(float vol)
	{
		audiosourceSE09.clip = SE09;
		audiosourceSE09.Play();
	}
	public void PlayCAR01(float vol)
	{
		// アイドル用のため、LOOPに設定.
		if(audiosourceCAR01.isPlaying == true)
		{
			audiosourceCAR01.Stop();
		}
		else{
			audiosourceCAR01.clip = CAR01;
			audiosourceCAR01.loop = true;
			audiosourceCAR01.Play();

		}

	}
	public void PlayCAR02(float vol)
	{
		audiosourceCAR02.clip = CAR02;
		audiosourceCAR02.PlayOneShot(CAR02, vol);
	}
	public void PlayCAR03(float vol)
	{
		audiosourceCAR03.clip = CAR03;
		audiosourceCAR03.PlayOneShot(CAR03, vol);
	}
	public void PlayCAR04(float vol)
	{
		audiosourceCAR04.clip = CAR04;
		audiosourceCAR04.PlayOneShot(CAR04, vol);
	}
	public void PlayCAR05(float vol)
	{
		audiosourceCAR05.clip = CAR05;
		audiosourceCAR05.PlayOneShot(CAR05, vol);
	}
	public void PlayCAR06(float vol)
	{
		audiosourceCAR06.clip = CAR06;
		audiosourceCAR06.PlayOneShot(CAR06, vol);
	}

	void OnGUI()
	{
		if(GUILayout.Button ("Play"))
		{
			audiosourceBGM.Play();
			Debug.Log("PlayStart");
		}

		if(GUILayout.Button ("Stop"))
		{
			audiosourceBGM.Stop();
			Debug.Log("BGM Stop");
		}

		if(GUILayout.Button ("PlayBGM01"))
		{
			float Vol = 1.0f;
			PlayBGM01(Vol);
			Debug.Log("PlayBGM01" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayBGM02"))
		{
			float Vol = 2.0f;
			PlayBGM02(Vol);
			Debug.Log("PlayBGM02" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayBGM03"))
		{
			float Vol = 3.0f;
			PlayBGM03(Vol);
			Debug.Log("PlayBGM03" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayBGM04"))
		{
			float Vol = 4.0f;
			PlayBGM04(Vol);
			Debug.Log("PlayBGM04" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayBGM05"))
		{
			float Vol = 5.0f;
			PlayBGM05(Vol);
			Debug.Log("PlayBGM05" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayBGM06"))
		{
			float Vol = 6.0f;
			PlayBGM06(Vol);
			Debug.Log("PlayBGM06" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE01"))
		{
			float Vol = 1.0f;
			PlaySE01(Vol);
			Debug.Log("PlaySE01" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE02"))
		{
			float Vol = 1.0f;
			PlaySE02(Vol);
			Debug.Log("PlaySE02" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE03"))
		{
			float Vol = 1.0f;
			PlaySE03(Vol);
			Debug.Log("PlaySE03" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE04"))
		{
			float Vol = 1.0f;
			PlaySE04(Vol);
			Debug.Log("PlaySE04" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE05"))
		{
			float Vol = 1.0f;
			PlaySE05(Vol);
			Debug.Log("PlaySE05" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE06"))
		{
			float Vol = 1.0f;
			PlaySE06(Vol);
			Debug.Log("PlaySE06" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE07"))
		{
			float Vol = 1.0f;
			PlaySE07(Vol);
			Debug.Log("PlaySE07" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE08"))
		{
			float Vol = 1.0f;
			PlaySE08(Vol);
			Debug.Log("PlaySE08" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlaySE09"))
		{
			float Vol = 1.0f;
			PlaySE09(Vol);
			Debug.Log("PlaySE09" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR01"))
		{
			float Vol = 1.0f;
			PlayCAR01(Vol);
			Debug.Log("PlayCAR01" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR02"))
		{
			float Vol = 1.0f;
			PlayCAR02(Vol);
			Debug.Log("PlayCAR02" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR03"))
		{
			float Vol = 1.0f;
			PlayCAR03(Vol);
			Debug.Log("PlayCAR03" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR04"))
		{
			float Vol = 1.0f;
			PlayCAR04(Vol);
			Debug.Log("PlayCAR04" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR05"))
		{
			float Vol = 1.0f;
			PlayCAR05(Vol);
			Debug.Log("PlayCAR05" + " Vol" + Vol);
		}

		if(GUILayout.Button ("PlayCAR06"))
		{
			float Vol = 1.0f;
			PlayCAR06(Vol);
			Debug.Log("PlayCAR06" + " Vol" + Vol);
		}
	}
}
