using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public QuestManager subscribetPlayer;
    protected List<Quest> questsToGive = new List<Quest>();


    void StartQuest()
    {

    }

    void FinishQuest()
    {

    }

    void UpdateQuest()
    {

    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            subscribetPlayer = collision.gameObject.GetComponent<QuestManager>();
        }
    }


}
