using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    bool Goal;

    void OnTriggerEnter(Collider hit)
    {
        //プレイヤーがゴールに触れたら
        if (hit.gameObject.CompareTag("Player"))
        {
            Goal = true;
        }
    }
    public bool GetGoal()
    {
        return Goal;
    }
}
