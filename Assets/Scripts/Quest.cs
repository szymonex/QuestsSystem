using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public Quest()
    {
        questId = idGenerator;
        idGenerator++;

    }

    static int idGenerator = 0;
    int questId;
    public string questName;
    public int reward;
    public string description;

    public virtual void OnFinished()
    {
        //dźwięk
    }

    public virtual void OnStart()
    {
        //dźwięk
        Debug.Log("Kot");
    }

    public virtual void OnUpdate()
    {
        //dźwięk
    }







}
