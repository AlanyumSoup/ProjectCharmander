using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsTileExampleController : MonoBehaviour {

GameObject image1,image2,image3,image4,image5,image6,image7,image8,image9,image10,image11,image12,image13,image14;


	// Use this for initialization
	void Start () {
		image1 = GameObject.Find("image1");
		image2 = GameObject.Find("image2");
		image3 = GameObject.Find("image3");
		image4 = GameObject.Find("image4");
		image5 = GameObject.Find("image5");
		image6 = GameObject.Find("image6");
		image7 = GameObject.Find("image7");
		image8 = GameObject.Find("image8");
		image9 = GameObject.Find("image9");
		image10 = GameObject.Find("image10");
		image11 = GameObject.Find("image11");
		image12 = GameObject.Find("image12");
		image13 = GameObject.Find("image13");
		image14 = GameObject.Find("image14");

		
		
		tilesMove();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tilesMove(){
		iTween.MoveTo(image1, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce));

		iTween.MoveTo(image2, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.1f));

		iTween.MoveTo(image3, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.2f));

		iTween.MoveTo(image4, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.3f));

		iTween.MoveTo(image5, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.4f));

		iTween.MoveTo(image6, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.5f));

		iTween.MoveTo(image7, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.6f));

		iTween.MoveTo(image8, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.7f));

		iTween.MoveTo(image9, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.8f));

		iTween.MoveTo(image10, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",0.9f));

		iTween.MoveTo(image11, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",1.0f));

		iTween.MoveTo(image12, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",1.1f));

		iTween.MoveTo(image13, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",1.2f));

		iTween.MoveTo(image14, iTween.Hash("y", 3f,"time",1f,"easetype",iTween.EaseType.easeOutBounce,"delay",1.3f));
	}
}
