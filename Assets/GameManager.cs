﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private Field field;
	public WallFactory wallFactory;
	// Use this for initialization
	void Start () {
		field = new Field ();
		Debug.Log ("テトリスフィールドは" + field.GetRowCount + ", " + field.GetColumnCount);
		createFields ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	private void createFields(){
		for (int i = 0; i < field.GetRowCount; i++) {
			for (int j = 0; j < field.GetColumnCount; j++) {
				Vector3 pos = new Vector3 (0, field.GetRowCount -i, j);
				if (field.GetCellNumber (i, j) == (int)Field.BLOCKTYPE.WALL) {
					//	Debug.Log ("ブロック作成します" + i + ", " + j);
					wallFactory.CreateWall (pos);
				}
			}
		}
	}
}
