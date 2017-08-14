using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupNavigatorScript : MonoBehaviour {

	// Use this for initialization
	GameObject fukidashi;
	GameObject text1;
	Text text;
	//GameObject navigator;
	void Start () {
		fukidashi=GameObject.Find("Fukidashi");
		text1=GameObject.Find("Text1");
		text=text1.GetComponentInChildren<Text>();
		//navigator=GameObject.Find("Navigator");

		fukidashi.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 public IEnumerator firstNavi(){
		 yield return new WaitForSeconds(2);
		fukidashi.SetActive(true);
		fukidashi.GetComponent<Button>().enabled=false;
		yield return new WaitForSeconds(2);
		text.text="Firstly,\nMake the Great Wall.\nI will show you an example.";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
	}

	public IEnumerator secondNavi(){
		fukidashi.SetActive(true);
		text.text="Next,\nShake two dices.";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
		//fukidashi.SetActive(false);
		//yield break;
	}

	public IEnumerator thirdNavi(){
		fukidashi.SetActive(true);
		fukidashi.GetComponent<Button>().enabled=false;
		text.text="one dice is 3,\nThe other dice is 6.";
		yield return new WaitForSeconds(2);
		text.text="Kknskd skdnvk skdnvkn.\nJBJBbsdv kjnjnsd, jbjsdbv jb bjsbd sjd djbsjdbv.\n\n Start from..";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
		yield break;
	}

	public IEnumerator fourthNavi(){
		fukidashi.SetActive(true);
		fukidashi.GetComponent<Button>().enabled=false;
		text.text="4 tiles x 3 times.\nEach players get sdmvksm kmskdvk kmskdvm.";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
		yield break;

	}

	public IEnumerator fifthNavi(){
		fukidashi.SetActive(true);
		fukidashi.GetComponent<Button>().enabled=false;
		text.text="sdv sdv sdsekrmg ndsjnv jnsdjn sidn jd d djnjsnd sdjn sjnd sjnjsdnv.";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
		yield break;
		
	}

	public IEnumerator sixthNavi(){
		fukidashi.SetActive(true);
		fukidashi.GetComponent<Button>().enabled=false;
		text.text="sdv sdv sdsekrmg ndsjnv jnsdjn sidn jd d djnjsnd sdjn sjnd sjnjsdnv.";
		yield return new WaitForSeconds(2);
		fukidashi.GetComponent<Button>().enabled=true;
		yield break;
	}


}
