using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
	int counter=0;

	GameObject obj1;
	GameObject obj2;

	public Vector3 obj1XY;
	GameObject SecondTutorialObject;
	float thrownTilesZ;

	// Use this for initialization
	void Start () {
		SecondTutorialObject=GameObject.Find("SecondTutorialObject");
		thrownTilesZ=0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(counter==0){
		obj1=getClickObject();
		if(obj1!=null){
			obj1XY=obj1.transform.position;
			iTween.MoveBy(obj1,iTween.Hash("y",+0.1,"time",0.05f,"easetype",iTween.EaseType.linear));
			counter=1;
		}
		}
		
		else if(counter==1){
			obj2=getClickObject();
			if(obj2!=null&&obj1.GetComponent<TileAsset>().onTheCentre==false&&obj2.GetComponent<TileAsset>().onTheCentre==false){
				Vector3 obj2XY=obj2.transform.position;
				iTween.MoveTo(obj1,iTween.Hash("position",obj2XY,"time",0.1f,"easetype",iTween.EaseType.linear));
				iTween.MoveTo(obj2,iTween.Hash("position",obj1XY,"time",0.1f,"easetype",iTween.EaseType.linear));
				obj1=null;
				obj2=null;
				counter=0;
			
			}
			else if(obj2!=null&&obj1.GetComponent<TileAsset>().onTheCentre==true&&obj2.GetComponent<TileAsset>().onTheCentre==false){
				Vector3 obj2XY=obj2.transform.position;
				iTween.MoveTo(obj1,iTween.Hash("position",obj2XY,"time",0.1f,"easetype",iTween.EaseType.linear));
				thrownTilesZ-=0.01f;
				iTween.MoveTo(obj2,iTween.Hash("position",new Vector3(-5f,-2f,thrownTilesZ),"time",0.1f,"easetype",iTween.EaseType.linear));
				obj1.GetComponent<TileAsset>().onTheCentre=false;
				obj1=null;
				obj2=null;
				counter=0;

				SecondTutorialObject.GetComponent<TileSupply>().supplyATile();
			
			}
			else if(obj2!=null&&obj2.GetComponent<TileAsset>().onTheCentre==true&&obj1.GetComponent<TileAsset>().onTheCentre==false){
				//Vector3 obj2XY=obj2.transform.position;
				thrownTilesZ-=0.01f;
				iTween.MoveTo(obj1,iTween.Hash("position",new Vector3(-5f,-2f,thrownTilesZ),"time",0.1f,"easetype",iTween.EaseType.linear));
				iTween.MoveTo(obj2,iTween.Hash("position",obj1XY,"time",0.1f,"easetype",iTween.EaseType.linear));
				obj2.GetComponent<TileAsset>().onTheCentre=false;
				obj1=null;
				obj2=null;
				counter=0;

				SecondTutorialObject.GetComponent<TileSupply>().supplyATile();
			}
		}	
	}

	public GameObject getClickObject(){
		GameObject result =null;
		if(Input.GetMouseButtonDown(0)){
			//Debug.Log("getClickObject!======================");
			Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			if(Physics.Raycast(ray, out hit)){
				result=hit.collider.gameObject;
			}
		}
		return result;
		
	}
}
