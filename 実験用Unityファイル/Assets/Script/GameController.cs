using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public GoalScript goalObject;
    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        bool Goal = goalObject.GetGoal();
        if(Goal == true)
        {
            //オブジェクトをアクティブにする
            winnerLabelObject.SetActive(true);
        }
    }

}
