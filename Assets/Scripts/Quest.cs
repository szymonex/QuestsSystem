using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public Quest()
    {
        questId = idGenerator;
        idGenerator++;
    }

    static int idGenerator = 0;
    public int questId;
    public string questName;
    public int reward;
    public string description;
    public int? numberOfTargets;
    public bool isFinished = false;

    public virtual void OnFinished()
    {
        //dźwięk
        isFinished = true;     
    }

    public virtual void OnStart(int? numberOfTargets)
    {
        //dźwięk
    }

    public virtual void OnUpdate()
    {
        //dźwięk
    }
}
