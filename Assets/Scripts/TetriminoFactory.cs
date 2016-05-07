using UnityEngine;
using System.Collections;

public class TetriminoFactory : MonoBehaviour {
	public GameObject TetriminoPrefab;
	public GameObject tetriminoParentPrefab;
	private TetriminoDatabase tetriminoDatabase;

	// Use this for initialization
	void Start () {
		tetriminoDatabase = new TetriminoDatabase ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateTetrimino(Vector3 basePos){
		int[,] tetArray = tetriminoDatabase.GetRandomTetriminoArray ();
		createTetriminoObject (tetArray,basePos);
	}

	private void createTetriminoObject(int[,] tetArray,Vector3 basePos){
		var tetParent = GameObject.Instantiate (tetriminoParentPrefab, basePos, Quaternion.identity) as GameObject;
		for(int i =0; i< tetArray.GetLength(0); i++){
			for(int j= 0; j < tetArray.GetLength(1); j++){
				//Debug.Log (tetArray [i, j]);
				if (tetArray [i, j] == 2) {
					var tetrimino = GameObject.Instantiate (TetriminoPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
					tetrimino.transform.SetParent (tetParent.transform);
					Vector3 pos = new Vector3 (0, i, j);
					tetrimino.transform.localPosition = pos;
					}
			}
		}
	}
}
