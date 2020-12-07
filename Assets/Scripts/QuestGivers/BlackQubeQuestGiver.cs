using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackQubeQuestGiver : QuestGiver
{
    public BlackQubeQuestGiver()
    {
        base.questsToGive.Add(new CollectRedCubes());
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        if (collision.gameObject.tag == "Player")
        {
            var questToAdd = base.questsToGive.Find(q => q.questName == "3 czerwone kostki");
            if (subscribetPlayer != null && !subscribetPlayer.Quests.Contains(questToAdd))
            {
                subscribetPlayer.Quests.Add(questToAdd);
                questToAdd.OnStart();
                Debug.Log("Słowik");
            }
        }
    }

}
