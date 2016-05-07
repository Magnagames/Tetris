﻿using UnityEngine;
using System.Collections;

public class TetriminoController : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		// 移動処理
			Move();
	}

	// 移動関数
	void Move(){
		// 現在位置をPositionに代入
		Vector3 Position = transform.position;
		// 左キーを押し続けていたら
		if(Input.GetKey("left")){
			// 代入したPositionに対して加算減算を行う
			Position.z -= 1f;
		} else if(Input.GetKey("right")){ // 右キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.z += 1f;
		} else if(Input.GetKey("up")){ // 上キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.y += 1f;
		} else if(Input.GetKey("down")){ // 下キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.y -= 1f;
		}
		// 現在の位置に加算減算を行ったPositionを代入する
		transform.position = Position;
	}

}
