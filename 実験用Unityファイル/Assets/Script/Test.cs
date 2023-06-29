using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //③コンポーネント(機能)に追加したいパラメーターを書ける
    //③変数をpublicで宣言すればUnityのエディタ上で編集できる。
    public float speed;

    //①Start : ゲームのオブジェクトが出現したときに一度だけ実行する処理
    void Start()
    {
        
    }

    //①Update : ゲームのオブジェクトが動くときに毎回実行する処理
    void Update()
    {
        //②position(座標)をVecter3.up(上)にspeed分増やす
        //transform.position += Vector3.up * speed;

        //④ほかのコンポーネントの取得
        //GetComponent : オブジェクトについているコンポーネントの取得
        //AddForce : 物理の物体に力を加える
        //右にスピード分力を加える
        GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        //重力を無効にする。
        GetComponent<Rigidbody>().useGravity = false;
        //testコンポーネント(このコンポーネント)のspeedを10にする
        GetComponent<Test>().speed = 10;
    }

    //①FixedUpdate : 物理運動にやらせたいことがあるときに毎回実行する処理
    private void FixedUpdate()
    {
        
    }
}
