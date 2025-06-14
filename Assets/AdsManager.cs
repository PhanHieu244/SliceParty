using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdsManager : MonoBehaviour
{
	public static AdsManager Instance;



	void Awake() { Instance=this; }

	public void ShowInterstitial()
	{
	}
}
