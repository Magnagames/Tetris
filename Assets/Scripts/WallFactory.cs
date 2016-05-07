using UnityEngine;
using System.Collections;

public class WallFactory : MonoBehaviour {
	public GameObject WallPrefab;

	public void CreateWall(Vector3 pos){
		var wall = GameObject.Instantiate (WallPrefab, pos, Quaternion.identity) as GameObject;
	}
}
