using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : Unit
{
    public override void Initialize(string name, int maxHealth, float speed)
    {
        base.Initialize(name, maxHealth, speed);

        Debug.Log("BOSS ENEMY SPAWNED");
    }
}
