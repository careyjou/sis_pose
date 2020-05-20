# sis_pose
> *體感偵測硬體*
>> NVIDIA Jetson Nano & Webcam
* ![GITHUB]( https://i.ytimg.com/vi/Ago-QUTD8_Y/hqdefault.jpg "Jetson Nano")

> *keypoints 骨架關鍵點*
>> COCO 17
* ![GITHUB]( http://www.programmersought.com/images/935/c3a73bf51c47252f4a33566327e30a87.png "COCO 17")
>> openpose 18
* ![GITHUB]( https://images2017.cnblogs.com/blog/945479/201712/945479-20171216223955061-1066574044.png "openpose 18")

> *UNITY載入keypoints*
>> SisBone.cs
>>> 示範如何取得鼻子的座標
```
    void Update()
	{
		Timer += Time.deltaTime;
		if (Timer > (1 / FrameRate))
		{
			Timer = 0;
			Debug.Log("nose_x:" + N[NowFrame]["keypoints"][(int)SisPointsNum.nose][1]);
			Debug.Log("nose_y:" + N[NowFrame]["keypoints"][(int)SisPointsNum.nose][2]);

			NowFrame = NowFrame + 1;
		}
	}
    ```
