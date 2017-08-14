using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectanglesController : MonoBehaviour {

	//GameObject yellow1,red1,red2,red3,red4;
	// Use this for initialization
	void Start () {
		//yellow1=GameObject.Find("Yellow1");
		//red1=GameObject.Find("Red1");
		//red2=GameObject.Find("Red2");
		//red3=GameObject.Find("Red3");
		//red4=GameObject.Find("Red4");

		flash();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void flash(){
		iTween.ValueTo(gameObject,iTween.Hash("from",0f,"to",1f,"time",0.5f,"onupdate","SetValue","looptype","pingpong","easetype",iTween.EaseType.easeInOutSine));
	}

	public void SetValue(float fedeInAlpha){
		gameObject.GetComponent<CanvasGroup>().alpha=fedeInAlpha;
	}
}
