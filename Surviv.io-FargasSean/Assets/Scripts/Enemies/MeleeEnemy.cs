using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Unit
{
    public override void Initialize(string name, int maxHealth, float speed)
    {
        base.Initialize(name, maxHealth, speed);

        Debug.Log("MELEE ENEMY SPAWNED");
    }
}
