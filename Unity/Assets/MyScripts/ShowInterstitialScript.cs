using UnityEngine;
using System;
using System.Collections;

public class ShowInterstitialScript : MonoBehaviour
{
	GameObject InitText;
	GameObject LoadButton;
	GameObject LoadText;
	GameObject ShowButton;
	GameObject ShowText;

 	public static String INTERSTITIAL_INSTANCE_ID = "0";

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("unity-script: ShowInterstitialScript Start called");

		LoadButton = GameObject.Find ("LoadInterstitial");
		LoadText = GameObject.Find ("LoadInterstitialText");
		LoadText.GetComponent<UnityEngine.UI.Text> ().color = UnityEngine.Color.blue;
		
		ShowButton = GameObject.Find ("ShowInterstitial");
		ShowText = GameObject.Find ("ShowInterstitialText");
		ShowText.GetComponent<UnityEngine.UI.Text> ().color = UnityEngine.Color.red;

		// Add Interstitial Events
		IronSourceInterstitialEvents.onAdReadyEvent += InterstitialOnAdReadyEvent;
		IronSourceInterstitialEvents.onAdLoadFailedEvent += InterstitialOnAdLoadFailed;
		IronSourceInterstitialEvents.onAdOpenedEvent += InterstitialOnAdOpenedEvent;
		IronSourceInterstitialEvents.onAdClickedEvent += InterstitialOnAdClickedEvent;
		IronSourceInterstitialEvents.onAdShowSucceededEvent += InterstitialOnAdShowSucceededEvent;
		IronSourceInterstitialEvents.onAdShowFailedEvent += InterstitialOnAdShowFailedEvent;
		IronSourceInterstitialEvents.onAdClosedEvent += InterstitialOnAdClosedEvent;

	}

	/************* Interstitial API *************/ 
	public void LoadInterstitialButtonClicked ()
	{
		Debug.Log ("unity-script: LoadInterstitialButtonClicked");
		IronSource.Agent.loadInterstitial ();
	}
	
	public void ShowInterstitialButtonClicked ()
	{
		Debug.Log ("unity-script: ShowInterstitialButtonClicked");
		if (IronSource.Agent.isInterstitialReady ()) {
			IronSource.Agent.showInterstitial ();
		} else {
			Debug.Log ("unity-script: IronSource.Agent.isInterstitialReady - False");
		}
	}
	
	void InterstitialOnAdReadyEvent(IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdReadyEvent With AdInfo " + adInfo);
	}

	void InterstitialOnAdLoadFailed(IronSourceError ironSourceError)
	{
		Debug.Log("unity-script: I got InterstitialOnAdLoadFailed With Error " + ironSourceError);
	}

	void InterstitialOnAdOpenedEvent(IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdOpenedEvent With AdInfo " + adInfo);
	}

	void InterstitialOnAdClickedEvent(IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdClickedEvent With AdInfo " + adInfo);
	}

	void InterstitialOnAdShowSucceededEvent(IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdShowSucceededEvent With AdInfo " + adInfo);
	}

	void InterstitialOnAdShowFailedEvent(IronSourceError ironSourceError, IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdShowFailedEvent With Error " + ironSourceError + " And AdInfo " + adInfo);
	}

	void InterstitialOnAdClosedEvent(IronSourceAdInfo adInfo)
	{
		Debug.Log("unity-script: I got InterstitialOnAdClosedEvent With AdInfo " + adInfo);
	}
}

