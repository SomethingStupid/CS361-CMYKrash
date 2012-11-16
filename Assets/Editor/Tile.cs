using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
	
	public float LH;
	protected GameManagement gm;
	
	// Use this for initialization
	void Start () {
		gm = Camera.main.GetComponent<GameManagement>();
		//scaling the tile to lane height
		LH = gm.GetLaneHeight();
		Vector3 scale = new Vector3(LH,LH,0);
		transform.localScale = scale;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
