using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRedCubes : Quest
{
    public CollectRedCubes()
    {
        questName = "3 czerwone kostki";
        description = "Zbierz 3 czerwone kostki!";
        reward = 300;
    }

    public override void OnStart()
    {
        base.OnStart();
        Debug.Log("Pies");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }

    public override void OnFinished()
    {
        base.OnFinished();
    }
}
