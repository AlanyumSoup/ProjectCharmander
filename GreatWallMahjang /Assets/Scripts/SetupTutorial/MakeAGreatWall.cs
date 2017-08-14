using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAGreatWall : MonoBehaviour {
public GameObject tempGameObject,mainCamera;
public int numOfTiles;
public int[] resultSouth;
public int[] resultWest;
public int[] resultNorth;
public int[] resultEast;

public List<GameObject> eastPlayersTiles,southPlayersTiles,westPlayersTiles,northPlayersTiles;
int cnt = 144;
	// Use this for initialization
	void Start () {
		mainCamera=GameObject.Find("Main Camera");
		numOfTiles=36;
		resultWest= new int[numOfTiles];
		resultNorth=new int[numOfTiles];
		resultEast=new int[numOfTiles];
		resultSouth=new int[numOfTiles];

		iTween.RotateTo(gameObject,iTween.Hash("x",0f,"y",0f,"z",0f));

		/* 
		tilesMakeAGreatWall();
		Invoke("cameraZoomOut",6);
		Invoke("cameraXRotationChange",6);
		Invoke("playersGetTilesForStart",8);
		Invoke("standupTiles",17);
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator tilesMakeAGreatWall(){
		

		//add all tiles into a list
		List<int> numbers = new List<int>(cnt);
		for(int i =1;i<=cnt;i++)
		{
			numbers.Add(i);
		}
		//make 36 randam tile for South and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			resultSouth[i]=numbers[random];
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at South
		float zPositionSouth=8f;
		float setTime=1f;
		int topBottomCounter=0;
		for(int i=0;i<resultSouth.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultSouth[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(-8f,0.3f,zPositionSouth),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(-8f,0.9f,zPositionSouth),"time",setTime,"easetype",iTween.EaseType.linear));
				zPositionSouth--;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"z",90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for West and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultWest[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at West
		float xPositionWest=10.5f;
		for(int i=0;i<resultWest.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultWest[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionWest,0.3f,4f),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionWest,0.9f,4f),"time",setTime,"easetype",iTween.EaseType.linear));
				xPositionWest--;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for North and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultNorth[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at North
		float zPositionNorth=-14.5f;
		for(int i=0;i<resultNorth.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultNorth[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(7,0.3f,zPositionNorth),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(7,0.9f,zPositionNorth),"time",setTime,"easetype",iTween.EaseType.linear));
				zPositionNorth++;;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"z",90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for East and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultEast[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at East
		float xPositionEast=-11.5f;
		for(int i=0;i<resultEast.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultEast[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionEast,0.3f,-10.5f),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionEast,0.9f,-10.5f),"time",setTime,"easetype",iTween.EaseType.linear));
				xPositionEast++;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}
		yield break;
	}


	public IEnumerator cameraZoomOut(){
		iTween.ValueTo(gameObject,iTween.Hash("from",78f,"to",102f,"time",0.5f,"onupdate","setCameraViewValue"));
		yield break;
	}
	public void setCameraViewValue(float view){
		mainCamera.GetComponent<Camera>().fieldOfView=view;
	}

	public IEnumerator cameraXRotationChange(){
		iTween.ValueTo(gameObject,iTween.Hash("from",50f,"to",60f,"time",0.5f,"onupdate","setCameraXRotationValue"));
		yield break;
	}

	public void setCameraXRotationValue(float xRote){
		mainCamera.transform.eulerAngles = new Vector3(xRote,0f,0f);
	}


	public IEnumerator playersGetTilesForStart(){

		//1st 4 to East
		GameObject playersTempTile1= GameObject.Find(resultEast[35].ToString());
		iTween.MoveTo(playersTempTile1,iTween.Hash("position",new Vector3(-7f,0.3f,-17f),"time",1f));

		GameObject playersTempTile2= GameObject.Find(resultEast[34].ToString());
		iTween.MoveTo(playersTempTile2,iTween.Hash("position",new Vector3(-6f,0.3f,-17f),"time",1f));

		GameObject playersTempTile3= GameObject.Find(resultEast[33].ToString());
		iTween.MoveTo(playersTempTile3,iTween.Hash("position",new Vector3(-5f,0.3f,-17f),"time",1f));

		GameObject playersTempTile4= GameObject.Find(resultEast[32].ToString());
		iTween.MoveTo(playersTempTile4,iTween.Hash("position",new Vector3(-4f,0.3f,-17f),"time",1f));

		eastPlayersTiles.Add(playersTempTile1);
		eastPlayersTiles.Add(playersTempTile2);
		eastPlayersTiles.Add(playersTempTile3);
		eastPlayersTiles.Add(playersTempTile4);



		//1st 4 to South
		GameObject playersTempTile5= GameObject.Find(resultEast[31].ToString());
		iTween.MoveTo(playersTempTile5,iTween.Hash("position",new Vector3(-17f,0.3f,1f),"time",1f,"delay",0.5f));
		iTween.RotateTo(playersTempTile5,iTween.Hash("y",-90f,"time",0.1f,"delay",0.5f));

		GameObject playersTempTile6= GameObject.Find(resultEast[30].ToString());
		iTween.MoveTo(playersTempTile6,iTween.Hash("position",new Vector3(-17f,0.3f,0f),"time",1f,"delay",0.5f));
		iTween.RotateTo(playersTempTile6,iTween.Hash("y",-90f,"time",0.1f,"delay",0.5f));

		GameObject playersTempTile7= GameObject.Find(resultEast[29].ToString());
		iTween.MoveTo(playersTempTile7,iTween.Hash("position",new Vector3(-17f,0.3f,-1f),"time",1f,"delay",0.5f));
		iTween.RotateTo(playersTempTile7,iTween.Hash("y",-90f,"time",0.1f,"delay",0.5f));

		GameObject playersTempTile8= GameObject.Find(resultEast[28].ToString());
		iTween.MoveTo(playersTempTile8,iTween.Hash("position",new Vector3(-17f,0.3f,-2f),"time",1f,"delay",0.5f));
		iTween.RotateTo(playersTempTile8,iTween.Hash("y",-90f,"time",0.1f,"delay",0.5f));

		southPlayersTiles.Add(playersTempTile5);
		southPlayersTiles.Add(playersTempTile6);
		southPlayersTiles.Add(playersTempTile7);
		southPlayersTiles.Add(playersTempTile8);

		
		//1st 4 to West
		GameObject playersTempTile9= GameObject.Find(resultEast[27].ToString());
		iTween.MoveTo(playersTempTile9,iTween.Hash("position",new Vector3(8f,0.3f,11f),"time",1f,"delay",1f));
		
		GameObject playersTempTile10= GameObject.Find(resultEast[26].ToString());
		iTween.MoveTo(playersTempTile10,iTween.Hash("position",new Vector3(7f,0.3f,11f),"time",1f,"delay",1f));
		
		GameObject playersTempTile11= GameObject.Find(resultEast[25].ToString());
		iTween.MoveTo(playersTempTile11,iTween.Hash("position",new Vector3(6f,0.3f,11f),"time",1f,"delay",1f));
		
		GameObject playersTempTile12= GameObject.Find(resultEast[24].ToString());
		iTween.MoveTo(playersTempTile12,iTween.Hash("position",new Vector3(5f,0.3f,11f),"time",1f,"delay",1f));

		westPlayersTiles.Add(playersTempTile9);
		westPlayersTiles.Add(playersTempTile10);
		westPlayersTiles.Add(playersTempTile11);
		westPlayersTiles.Add(playersTempTile12);
	

		//1st 4 to North
		GameObject playersTempTile13= GameObject.Find(resultEast[23].ToString());
		iTween.MoveTo(playersTempTile13,iTween.Hash("position",new Vector3(17f,0.3f,4-12f),"time",1f,"delay",1.5f));
		iTween.RotateTo(playersTempTile13,iTween.Hash("y",-90f,"time",0.1f,"delay",1.5f));

		GameObject playersTempTile14= GameObject.Find(resultEast[22].ToString());
		iTween.MoveTo(playersTempTile14,iTween.Hash("position",new Vector3(17f,0.3f,-11f),"time",1f,"delay",1.5f));
		iTween.RotateTo(playersTempTile14,iTween.Hash("y",-90f,"time",0.1f,"delay",1.5f));

		GameObject playersTempTile15= GameObject.Find(resultEast[21].ToString());
		iTween.MoveTo(playersTempTile15,iTween.Hash("position",new Vector3(17f,0.3f,-10f),"time",1f,"delay",1.5f));
		iTween.RotateTo(playersTempTile15,iTween.Hash("y",-90f,"time",0.1f,"delay",1.5f));

		GameObject playersTempTile16= GameObject.Find(resultEast[20].ToString());
		iTween.MoveTo(playersTempTile16,iTween.Hash("position",new Vector3(17f,0.3f,-9f),"time",1f,"delay",1.5f));
		iTween.RotateTo(playersTempTile16,iTween.Hash("y",-90f,"time",0.1f,"delay",1.5f));

		northPlayersTiles.Add(playersTempTile13);
		northPlayersTiles.Add(playersTempTile14);
		northPlayersTiles.Add(playersTempTile15);
		northPlayersTiles.Add(playersTempTile16);


		//2st 4 to East
		GameObject playersTempTile17= GameObject.Find(resultEast[19].ToString());
		iTween.MoveTo(playersTempTile17,iTween.Hash("position",new Vector3(-3f,0.3f,-17f),"time",1f,"delay",2f));

		GameObject playersTempTile18= GameObject.Find(resultEast[18].ToString());
		iTween.MoveTo(playersTempTile18,iTween.Hash("position",new Vector3(-2f,0.3f,-17f),"time",1f,"delay",2f));

		GameObject playersTempTile19= GameObject.Find(resultEast[17].ToString());
		iTween.MoveTo(playersTempTile19,iTween.Hash("position",new Vector3(-1f,0.3f,-17f),"time",1f,"delay",2f));

		GameObject playersTempTile20= GameObject.Find(resultEast[16].ToString());
		iTween.MoveTo(playersTempTile20,iTween.Hash("position",new Vector3(0f,0.3f,-17f),"time",1f,"delay",2f));

		eastPlayersTiles.Add(playersTempTile17);
		eastPlayersTiles.Add(playersTempTile18);
		eastPlayersTiles.Add(playersTempTile19);
		eastPlayersTiles.Add(playersTempTile20);

		//2st 4 to South
		GameObject playersTempTile21= GameObject.Find(resultEast[15].ToString());
		iTween.MoveTo(playersTempTile21,iTween.Hash("position",new Vector3(-17f,0.3f,-3f),"time",1f,"delay",2.5f));
		iTween.RotateTo(playersTempTile21,iTween.Hash("y",-90f,"time",0.1f,"delay",2.5f));

		GameObject playersTempTile22= GameObject.Find(resultEast[14].ToString());
		iTween.MoveTo(playersTempTile22,iTween.Hash("position",new Vector3(-17f,0.3f,-4f),"time",1f,"delay",2.5f));
		iTween.RotateTo(playersTempTile22,iTween.Hash("y",-90f,"time",0.1f,"delay",2.5f));

		GameObject playersTempTile23= GameObject.Find(resultEast[13].ToString());
		iTween.MoveTo(playersTempTile23,iTween.Hash("position",new Vector3(-17f,0.3f,-5f),"time",1f,"delay",2.5f));
		iTween.RotateTo(playersTempTile23,iTween.Hash("y",-90f,"time",0.1f,"delay",2.5f));

		GameObject playersTempTile24= GameObject.Find(resultEast[12].ToString());
		iTween.MoveTo(playersTempTile24,iTween.Hash("position",new Vector3(-17f,0.3f,-6f),"time",1f,"delay",2.5f));
		iTween.RotateTo(playersTempTile24,iTween.Hash("y",-90f,"time",0.1f,"delay",2.5f));

		southPlayersTiles.Add(playersTempTile21);
		southPlayersTiles.Add(playersTempTile22);
		southPlayersTiles.Add(playersTempTile23);
		southPlayersTiles.Add(playersTempTile24);


		//2st 4 to West
		GameObject playersTempTile25= GameObject.Find(resultEast[11].ToString());
		iTween.MoveTo(playersTempTile25,iTween.Hash("position",new Vector3(4f,0.3f,11f),"time",1f,"delay",3f));
		
		GameObject playersTempTile26= GameObject.Find(resultEast[10].ToString());
		iTween.MoveTo(playersTempTile26,iTween.Hash("position",new Vector3(3f,0.3f,11f),"time",1f,"delay",3f));
		
		GameObject playersTempTile27= GameObject.Find(resultEast[9].ToString());
		iTween.MoveTo(playersTempTile27,iTween.Hash("position",new Vector3(2f,0.3f,11f),"time",1f,"delay",3f));
		
		GameObject playersTempTile28= GameObject.Find(resultEast[8].ToString());
		iTween.MoveTo(playersTempTile28,iTween.Hash("position",new Vector3(1f,0.3f,11f),"time",1f,"delay",3f));

		westPlayersTiles.Add(playersTempTile25);
		westPlayersTiles.Add(playersTempTile26);
		westPlayersTiles.Add(playersTempTile27);
		westPlayersTiles.Add(playersTempTile28);


		//2st 4 to North
		GameObject playersTempTile29= GameObject.Find(resultEast[7].ToString());
		iTween.MoveTo(playersTempTile29,iTween.Hash("position",new Vector3(17f,0.3f,4-8f),"time",1f,"delay",3.5f));
		iTween.RotateTo(playersTempTile29,iTween.Hash("y",-90f,"time",0.1f,"delay",3.5f));

		GameObject playersTempTile30= GameObject.Find(resultEast[6].ToString());
		iTween.MoveTo(playersTempTile30,iTween.Hash("position",new Vector3(17f,0.3f,-7f),"time",1f,"delay",3.5f));
		iTween.RotateTo(playersTempTile30,iTween.Hash("y",-90f,"time",0.1f,"delay",3.5f));

		GameObject playersTempTile31= GameObject.Find(resultEast[5].ToString());
		iTween.MoveTo(playersTempTile31,iTween.Hash("position",new Vector3(17f,0.3f,-6f),"time",1f,"delay",3.5f));
		iTween.RotateTo(playersTempTile31,iTween.Hash("y",-90f,"time",0.1f,"delay",3.5f));

		GameObject playersTempTile32= GameObject.Find(resultEast[4].ToString());
		iTween.MoveTo(playersTempTile32,iTween.Hash("position",new Vector3(17f,0.3f,-5f),"time",1f,"delay",3.5f));
		iTween.RotateTo(playersTempTile32,iTween.Hash("y",-90f,"time",0.1f,"delay",3.5f));

		northPlayersTiles.Add(playersTempTile29);
		northPlayersTiles.Add(playersTempTile30);
		northPlayersTiles.Add(playersTempTile31);
		northPlayersTiles.Add(playersTempTile32);


		//3st 4 to East
		GameObject playersTempTile33= GameObject.Find(resultEast[3].ToString());
		iTween.MoveTo(playersTempTile33,iTween.Hash("position",new Vector3(1f,0.3f,-17f),"time",1f,"delay",4f));

		GameObject playersTempTile34= GameObject.Find(resultEast[2].ToString());
		iTween.MoveTo(playersTempTile34,iTween.Hash("position",new Vector3(2f,0.3f,-17f),"time",1f,"delay",4f));

		GameObject playersTempTile35= GameObject.Find(resultEast[1].ToString());
		iTween.MoveTo(playersTempTile35,iTween.Hash("position",new Vector3(3f,0.3f,-17f),"time",1f,"delay",4f));

		GameObject playersTempTile36= GameObject.Find(resultEast[0].ToString());
		iTween.MoveTo(playersTempTile36,iTween.Hash("position",new Vector3(4f,0.3f,-17f),"time",1f,"delay",4f));

		eastPlayersTiles.Add(playersTempTile33);
		eastPlayersTiles.Add(playersTempTile34);
		eastPlayersTiles.Add(playersTempTile35);
		eastPlayersTiles.Add(playersTempTile36);


		//3st 4 to South
		GameObject playersTempTile37= GameObject.Find(resultSouth[35].ToString());
		iTween.MoveTo(playersTempTile37,iTween.Hash("position",new Vector3(-17f,0.3f,-7f),"time",1f,"delay",4.5f));

		GameObject playersTempTile38= GameObject.Find(resultSouth[34].ToString());
		iTween.MoveTo(playersTempTile38,iTween.Hash("position",new Vector3(-17f,0.3f,-8f),"time",1f,"delay",4.5f));

		GameObject playersTempTile39= GameObject.Find(resultSouth[33].ToString());
		iTween.MoveTo(playersTempTile39,iTween.Hash("position",new Vector3(-17f,0.3f,-9f),"time",1f,"delay",4.5f));

		GameObject playersTempTile40= GameObject.Find(resultSouth[32].ToString());
		iTween.MoveTo(playersTempTile40,iTween.Hash("position",new Vector3(-17f,0.3f,-10f),"time",1f,"delay",4.5f));

		southPlayersTiles.Add(playersTempTile37);
		southPlayersTiles.Add(playersTempTile38);
		southPlayersTiles.Add(playersTempTile39);
		southPlayersTiles.Add(playersTempTile40);


		//3st 4 to West
		GameObject playersTempTile41= GameObject.Find(resultSouth[31].ToString());
		iTween.MoveTo(playersTempTile41,iTween.Hash("position",new Vector3(0f,0.3f,11f),"time",1f,"delay",5f));
		iTween.RotateTo(playersTempTile41,iTween.Hash("y",-180f,"time",0.1f,"delay",5f));

		GameObject playersTempTile42= GameObject.Find(resultSouth[30].ToString());
		iTween.MoveTo(playersTempTile42,iTween.Hash("position",new Vector3(-1f,0.3f,11f),"time",1f,"delay",5f));
		iTween.RotateTo(playersTempTile42,iTween.Hash("y",-180f,"time",0.1f,"delay",5f));

		GameObject playersTempTile43= GameObject.Find(resultSouth[29].ToString());
		iTween.MoveTo(playersTempTile43,iTween.Hash("position",new Vector3(-2f,0.3f,11f),"time",1f,"delay",5f));
		iTween.RotateTo(playersTempTile43,iTween.Hash("y",-180f,"time",0.1f,"delay",5f));

		GameObject playersTempTile44= GameObject.Find(resultSouth[28].ToString());
		iTween.MoveTo(playersTempTile44,iTween.Hash("position",new Vector3(-3f,0.3f,11f),"time",1f,"delay",5f));
		iTween.RotateTo(playersTempTile44,iTween.Hash("y",-180f,"time",0.1f,"delay",5f));

		westPlayersTiles.Add(playersTempTile41);
		westPlayersTiles.Add(playersTempTile42);
		westPlayersTiles.Add(playersTempTile43);
		westPlayersTiles.Add(playersTempTile44);


		//3st 4 to North
		GameObject playersTempTile45= GameObject.Find(resultSouth[27].ToString());
		iTween.MoveTo(playersTempTile45,iTween.Hash("position",new Vector3(17f,0.3f,-3f),"time",1f,"delay",5.5f));

		GameObject playersTempTile46= GameObject.Find(resultSouth[26].ToString());
		iTween.MoveTo(playersTempTile46,iTween.Hash("position",new Vector3(17f,0.3f,-2f),"time",1f,"delay",5.5f));

		GameObject playersTempTile47= GameObject.Find(resultSouth[25].ToString());
		iTween.MoveTo(playersTempTile47,iTween.Hash("position",new Vector3(17f,0.3f,-1f),"time",1f,"delay",5.5f));

		GameObject playersTempTile48= GameObject.Find(resultSouth[24].ToString());
		iTween.MoveTo(playersTempTile48,iTween.Hash("position",new Vector3(17f,0.3f,0f),"time",1f,"delay",5.5f));

		northPlayersTiles.Add(playersTempTile45);
		northPlayersTiles.Add(playersTempTile46);
		northPlayersTiles.Add(playersTempTile47);
		northPlayersTiles.Add(playersTempTile48);

		

		
		
		yield break;
	}

	public IEnumerator lastOneTiles(){
		//4th 1 to East
		GameObject playersTempTile49= GameObject.Find(resultSouth[23].ToString());
		iTween.MoveTo(playersTempTile49,iTween.Hash("position",new Vector3(5f,0.3f,-17f),"time",1f));
		iTween.RotateTo(playersTempTile49,iTween.Hash("y",-180f,"time",0.1f));

		eastPlayersTiles.Add(playersTempTile49);
		//4th 1 to South
		GameObject playersTempTile50= GameObject.Find(resultSouth[22].ToString());
		iTween.MoveTo(playersTempTile50,iTween.Hash("position",new Vector3(-17f,0.3f,-11f),"time",1f,"delay",0.5f));
		
		southPlayersTiles.Add(playersTempTile50);

		//4th 1 to West
		GameObject playersTempTile51= GameObject.Find(resultSouth[21].ToString());
		iTween.MoveTo(playersTempTile51,iTween.Hash("position",new Vector3(-4f,0.3f,11f),"time",1f,"delay",1f));
		iTween.RotateTo(playersTempTile51,iTween.Hash("y",-180f,"time",0.1f,"delay",1f));

		westPlayersTiles.Add(playersTempTile51);

		//4th 1 to North
		GameObject playersTempTile52= GameObject.Find(resultSouth[20].ToString());
		iTween.MoveTo(playersTempTile52,iTween.Hash("position",new Vector3(17f,0.3f,1f),"time",1f,"delay",1.5f));

		northPlayersTiles.Add(playersTempTile52);
		
		yield break;
	}



	public IEnumerator standupTiles(){

		foreach(var x in eastPlayersTiles){
			iTween.RotateFrom(x,iTween.Hash("x",0f,"y",0f,"z",0f));
			iTween.RotateTo(x,iTween.Hash("x",25f,"y",0f,"z",0f,"time",0.5f));
			iTween.MoveTo(x,iTween.Hash("y",0.7f,"time",0.5f));
		}

		foreach(var x in southPlayersTiles){
			iTween.RotateFrom(x,iTween.Hash("x",0f,"y",0f,"z",0f));
			iTween.RotateTo(x,iTween.Hash("x",0f,"y",90f,"z",0f,"time",0.5f));
			iTween.MoveTo(x,iTween.Hash("y",0.7f,"time",0.5f));
		}

		foreach(var x in westPlayersTiles){
			iTween.RotateFrom(x,iTween.Hash("x",0f,"y",0f,"z",0f));
			iTween.RotateTo(x,iTween.Hash("x",-180f,"y",0f,"z",0f,"time",0.5f));
			iTween.MoveTo(x,iTween.Hash("y",0.7f,"time",0.5f));
		}

		foreach(var x in northPlayersTiles){
			iTween.RotateFrom(x,iTween.Hash("x",0f,"y",0f,"z",0f));
			iTween.RotateTo(x,iTween.Hash("x",0f,"y",-90f,"z",0f,"time",0.5f));
			iTween.MoveTo(x,iTween.Hash("y",0.7f,"time",0.5f));
		}

		yield break;
	}


}
