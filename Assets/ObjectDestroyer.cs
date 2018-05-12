using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {

    //DestoryPlaneのオブジェクト
    private GameObject DestoryPlane;

    // Use this for initialization
    void Start () {
        //DestoryPlaneのオブジェクトを取得
        this.DestoryPlane = GameObject.Find("DestoryPlane");
    }

    //トリガーモードで他のオブジェクトと接触したときの処理
    void OnTriggerEnter(Collider other)
    { 
        //オブジェクトに衝突した場合
        {
            //接触したオブジェクトを破棄
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
      
		
	}
}
