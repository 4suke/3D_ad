using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2Controll : MonoBehaviour {

    

    //Car2を移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;

    //前進するための力
    private float forwardForce = -50.0f;

	// Use this for initialization
	void Start () {

        //Rigidbodyコンポーネントを取得
        this.myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //Car2に前方向の力を加える
        this.myRigidbody.AddForce(this.transform.forward * this.forwardForce);
	}
}
