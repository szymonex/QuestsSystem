using UnityEngine;

public class RedQubeQuestGiver : QuestGiver
{
    [SerializeField] GameObject redCubeContainer;
    string redCubeQuestName;

    public RedQubeQuestGiver()
    {
        CollectRedCubesQuest collectRedCubesQuest = new CollectRedCubesQuest();
        redCubeQuestName = collectRedCubesQuest.questName;
        base.questsToGive.Add(collectRedCubesQuest);
    }

    private void Start()
    {
        if (redCubeContainer == null)
        {
            Debug.Log("Brak referencji dla obiektu redCubeCointainer");
        }
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        if (collision.gameObject.tag == "Player")
        {
            var questToAdd = base.questsToGive.Find(q => q.questName == redCubeQuestName);
            if (subscribedPlayer != null && !subscribedPlayer.Quests.Contains(questToAdd))
            {
                subscribedPlayer.Quests.Add(questToAdd);
                var numberOfTargets = redCubeContainer.gameObject.transform.childCount;
                questToAdd.OnStart(numberOfTargets);
                redCubeContainer.SetActive(true);            
            }
        }
    }
}
