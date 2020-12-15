using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> Quests { get; set; } = new List<Quest>();

    Quest GetLastQuest(int questPointer)
    {
        var quest = Quests.Find(q => q.questId == questPointer);
        return quest;
    }

    private void OnGUI()
    {
        if (Quests.Count > 0)
        {
            var quest = GetLastQuest(Quests.Count);
            GUI.TextField(new Rect(10, 10, 220, 30), $"Active Quests: {quest.questName}");
            GUI.TextField(new Rect(10, 40, 220, 30), $"Objects Left: {quest.numberOfTargets}");
            if (quest.isFinished)
            {
                GUI.TextField(new Rect(10, 70, 220, 30), $"Mision Complete! Reward: {quest.reward}");
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
