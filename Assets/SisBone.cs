using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using SimpleJSON;
public class SisBone : MonoBehaviour
{
	[SerializeField] string File_Name;

	Vector3[] points = new Vector3[17];

	private JSONNode N; 
	int NowFrame = 0;
	
	float Timer;
	float FrameRate = 5.0f;
	void Start()
	{
            StreamReader inp_stm = new StreamReader(Application.dataPath+ '/' + File_Name);
	
            while (!inp_stm.EndOfStream)
            {
                string inp_ln = inp_stm.ReadLine();
 
                N = JSON.Parse(inp_ln);
				Debug.Log(N.Count);
            }
 
            inp_stm.Close();
 	}

	void parseList()
	{

	}

	void Update()
	{
		Timer += Time.deltaTime;
		if (Timer > (1 / FrameRate))
		{
			Timer = 0;
			Debug.Log("x:" + N[NowFrame]["keypoints"][(int)SisPointsNum.nose][1] + ", y:" + N[NowFrame]["keypoints"][(int)SisPointsNum.nose][2]);
			/*
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.nose]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_eye]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_eye]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_ear]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_ear]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_shoulder]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_shoulder]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_elbow]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_elbow]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_wrist]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_wrist]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_hip]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_hip]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_knee]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_knee]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.left_ankle]);
			Debug.Log(N[NowFrame]["keypoints"][(int)SisPointsNum.right_ankle]);
			*/
			NowFrame = NowFrame + 1;
		}
	}

}
enum SisPointsNum
{
	nose,
	left_eye,
	right_eye,
	left_ear,
	right_ear,
	left_shoulder,
	right_shoulder,
	left_elbow,
	right_elbow,
	left_wrist,
	right_wrist,
	left_hip,
	right_hip,
	left_knee,
	right_knee,
	left_ankle,
	right_ankle
}