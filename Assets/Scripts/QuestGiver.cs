using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public QuestManager subscribedPlayer;
    protected List<Quest> questsToGive = new List<Quest>();

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            subscribedPlayer = collision.gameObject.GetComponent<QuestManager>();
            subscribedPlayer.enabled = true;
        }
    }
}
