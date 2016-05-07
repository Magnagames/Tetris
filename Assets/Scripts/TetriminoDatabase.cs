using UnityEngine;
using System.Collections;

public class TetriminoDatabase{
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


	//テトリミノのタイプ
	public enum TETRIMINO_TYPE
	{
		ITet=0,
		OTet,
		STet,
		ZTet,
		JTet,
		LTet,
		TTet,
		Num,
	};

	public TetriminoDatabase(){

	}

	//テトリミノ配列を返す
	public int[,] GetTetriminoArray(TETRIMINO_TYPE type){
		int[,] ret;
		switch (type) {

		case TETRIMINO_TYPE.ITet:
			ret = ITetArray;
			break;
		case TETRIMINO_TYPE.JTet:
			ret = JTetArray;
			break;
		case TETRIMINO_TYPE.LTet:
			ret = LTetArray;
			break;
		case TETRIMINO_TYPE.OTet:
			ret = OTetArray;
			break;
		case TETRIMINO_TYPE.STet:
			ret = STetArray;
			break;
		case TETRIMINO_TYPE.TTet:
			ret = TTetArray;
			break;
		case TETRIMINO_TYPE.ZTet:
			ret = ZTetArray;
			break;
		default :
			ret = ITetArray;
			break;

		}
		return ret;
	}

	public int[,] GetRandomTetriminoArray(){
		TETRIMINO_TYPE tetType = (TETRIMINO_TYPE)Random.Range (0, 7);
		return GetTetriminoArray (tetType);
	}
		
}
