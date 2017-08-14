using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WongController : MonoBehaviour {
	GameObject wong;
	GameObject greatWallfront3;
	GameObject greatWallfront2;

	GameObject title;
	// Use this for initialization
	void Start () {
		wong = GameObject.Find("wong1");
		greatWallfront3 = GameObject.Find("greatWallfront3");
		greatWallfront2 = GameObject.Find("greatWallfront2");
		title = GameObject.Find("Title");

		//path1
		iTween.MoveTo(wong, iTween.Hash("position",new Vector3(3.4f,2.45f,0),"time",2f,"easetype","linear","oncomplete","path2"));
		
		Invoke("titleMove",7.15f);
		//iTween.MoveTo(title,iTween.Hash("delay",8f,"oncomplete","titleMove"));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	

	public void path2(){
		
		Destroy(greatWallfront3);
		//greatWallfront3.SetActive(false);
		iTween.ScaleTo(wong,iTween.Hash("scale",new Vector3(0.06f,0.06f,0f),"time",1.9f,"easetype","linear"));
		iTween.MoveTo(wong,iTween.Hash("position",new Vector3(1.2f,1f,0),"time",1.9f,"easetype","linear","oncomplete","path3"));
	}

	public void path3(){
		//wong.transform.localScale+=new Vector3(0.03f,0.03f,0);
		Destroy(greatWallfront2);

		iTween.ScaleTo(wong,iTween.Hash("scale",new Vector3(0.13f,0.13f,0f),"time",1.5f,"easetype","linear"));
		iTween.MoveTo(wong,iTween.Hash("position",new Vector3(4,-2,0),"time",1.5f,"easetype","linear","oncomplete","path4"));
	}

	public void path4(){
		iTween.MoveTo(wong,iTween.Hash("position",new Vector3(-2.65f,-2f,0f),"time",1.82f,"easetype",iTween.EaseType.easeInCirc,"oncomplete","path5"));
		
	}
	public void path5(){
		iTween.MoveTo(wong,iTween.Hash("position",new Vector3(-2.65f,1f,0f),"time",0.447f,"easetype",iTween.EaseType.easeInOutExpo,"looptype",iTween.LoopType.pingPong));
	}

	public void titleMove(){
iTween.MoveTo(title, iTween.Hash("y",2.5f,"time",0.447f,"easetype",iTween.EaseType.easeInBack,"looptype",iTween.LoopType.pingPong));
	}
}
