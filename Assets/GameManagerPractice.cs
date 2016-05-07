using UnityEngine;
using System.Collections;

public class GameManagerPractice : MonoBehaviour {
	private TetriminoClass tetrimino;
	// Use this for initialization
	void Start () {
		tetrimino = new TetriminoClass ();
		int[,] tet = tetrimino.GetTetrymino (TetriminoClass.TETRYMINO_TYPE.ITET);
		for(int i = 0;i< tet.Length
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
