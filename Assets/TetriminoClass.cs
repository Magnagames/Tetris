using UnityEngine;
using System.Collections;

public class TetriminoClass : MonoBehaviour {

	public enum TETRYMINO_TYPE{
		ITET=0,
		OTET,
		STET,
		ZTET,
		JTET,
		LTET,
		CUBETET
	}

	public int[,] GetTetrymino(TETRYMINO_TYPE type){
		int[,] ret;
		switch (type) {
		case TETRYMINO_TYPE.OTET:
			ret = OTetArray;
			break;

		case TETRYMINO_TYPE.STET:
			ret = STetArray;
			break;

		case TETRYMINO_TYPE.ZTET:
			ret = ZTetArray;
			break;

		case TETRYMINO_TYPE.JTET:
			ret = JTetArray;
			break;
		case TETRYMINO_TYPE.LTET:
			ret = LTetArray;
			break;
		case TETRYMINO_TYPE.CUBETET:
			ret = CubeArray;
			break;

		default:
			break;

		}
		return ret;
	}


	private int[,] ITetArray = new int[,]
	{
		{2,2,2,2},
		{0,0,0,0},
		{0,0,0,0},
		{0,0,0,0},
	};

	private int[,] OTetArray = new int[,]
	{
		{0,0,0,0},
		{0,2,2,0},
		{0,2,2,0},
		{0,0,0,0},
	};

	private int[,] STetArray = new int[,]
	{
		{0,0,0,0},
		{0,2,2,0},
		{2,2,0,0},
		{0,0,0,0},
	};

	private int[,] ZTetArray = new int[,]
	{
		{0,0,0,0},
		{2,2,0,0},
		{0,2,2,0},
		{0,0,0,0},
	};

	private int[,] JTetArray = new int[,]
	{
		{0,0,0,0},
		{2,0,0,0},
		{2,2,2,0},
		{0,0,0,0},
	};

	private int[,] LTetArray = new int[,]
	{
		{0,0,0,0},
		{0,0,2,0},
		{2,2,2,0},
		{0,0,0,0},
	};

	private int[,] TTetArray = new int[,]
	{
		{0,0,0,0},
		{0,2,0,0},
		{2,2,2,0},
		{0,0,0,0},
	};

	private int[,] CubeArray = new int[,]
	{
		{0,2,2,0},
		{0,0,0,0},
		{0,0,0,0},
		{0,0,0,0},
	};

	private void CreateTet()
	{
		int tetIndex = Random.Range (7, 7);
		tetrimino = (Tetrimino)Instantiate (mTetrimino [tetIndex]);
		tetrimino.GetTet (tetIndex);
		mTetrimino.Add (tetrimino);
		tetrimino.transform.parent = GameObject.Find("FieldManager").transform;
		tetrimino.transform.localPosition = new Vector3 (1, 18.5f, 0);

		MakeField (0, 4);

		mCheckPhase = 4;

	}
}
