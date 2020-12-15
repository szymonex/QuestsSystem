using UnityEngine;

public class QuestObject : MonoBehaviour
{
    RedCubeContainer redCubeContainer;
    QuestManager playerQuestManager;
    Quest questToUpdate;

    void Start()
    {
        redCubeContainer = GetComponentInParent<RedCubeContainer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerQuestManager = collision.gameObject.GetComponent<QuestManager>();
            questToUpdate = playerQuestManager.Quests.Find(q => q.questName == "3 czerwone kostki");
            questToUpdate.OnUpdate();
            redCubeContainer.CheckChildsCount();
            Destroy(gameObject);
        }
    }
}
