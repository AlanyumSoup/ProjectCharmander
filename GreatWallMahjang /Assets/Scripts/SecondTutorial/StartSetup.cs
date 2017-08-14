using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		setupTiles();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setupTiles(){
		GameObject tmpGameObject;

		int xPosition=-7;
		float setTime=1f;
		float delayTime=2f;
		int numOfTiles = 14;
		int[] result= new int[numOfTiles];
		int cnt=144;

		List<int> numbers = new List<int>(cnt);
		for(int i =1;i<=cnt;i++)
		{
			numbers.Add(i);
		}

		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			result[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");

			cnt--;
			numbers.RemoveAt(random);
		}

		for(int i=0;i<result.Length;i++)
		{
			Debug.Log(result[i]);
			string tileName = result[i].ToString();
			Debug.Log(tileName+" OBJECT");
			tmpGameObject = GameObject.Find(tileName.ToString());
			iTween.MoveTo(tmpGameObject,iTween.Hash("position",new Vector3(xPosition,-4f,0f),"time",setTime,"easetype",iTween.EaseType.linear));
			tmpGameObject.GetComponent<TileAsset>().onTheBoard=true;
			iTween.RotateTo(tmpGameObject,iTween.Hash("y",180f,"time",0.1f,"looptype",iTween.LoopType.none));
			iTween.RotateTo(tmpGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			xPosition++;
			setTime+=0.1f;
			delayTime+=0.1f;
		}


	}
		
}
