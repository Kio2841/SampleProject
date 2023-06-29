using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWallScript : MonoBehaviour
{
    //移動方向フラグ
    //0なら移動しない
    //1なら横方向に移動
    //2なら縦方向に移動
    //3なら落ちる
    //4右回転
    //5左回転
    public int Direction = 0;
    bool fall = false;
    public float speed = 0.1f;
    private void OnCollisionEnter(Collision hit)
    {
        //接触したオブジェクトタグがPlayerだった場合
        if(hit.gameObject.CompareTag("Player"))
        {
            //現在のscene番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            //現在のsceneを再読み込み
            SceneManager.LoadScene(sceneIndex);
        }
        if (hit.gameObject.CompareTag("Wall"))
        {
            speed *= -1;
        }
        if (hit.gameObject.CompareTag("Tile"))
        {
            speed *= -1;
        }
    }
    private void Update()
    {

        //横移動
        if (Direction == 1)
        {
            transform.position += Vector3.right * speed;
        }
        //縦移動
        else if(Direction == 2)
        {
            transform.position += Vector3.forward * speed;
        }
        //上下移動
        else if (Direction == 3)
        {
            transform.position += Vector3.down * speed;
            if(transform.position.y >= 4.5)
            {
                speed *= -1;
            }
        }
        //回転
        else if(Direction == 4)
        {
            transform.Rotate(Vector3.up * speed);
        }
    }
}
