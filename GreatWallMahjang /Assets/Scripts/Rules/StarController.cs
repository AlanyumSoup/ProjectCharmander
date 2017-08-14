using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {


	// Use this for initialization
	void Start () {
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
