using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] DashManager dash;

    //[SerializeField] Enemy enemy;

    //private void Update()
    //{
    //    if (enemy.enemyKilled == true)
    //    {
    //        AddDashPoints();
    //        Debug.Log("add points");
    //    }
    //}

    public void AddDashPoints()
    {
        dash.AddDashPoints(10);
    }
}
