using UnityEngine;

public class CollectRedCubesQuest : Quest
{
    public CollectRedCubesQuest()
    {
        questName = "3 czerwone kostki";
        description = "Zbierz 3 czerwone kostki!";
        reward = 300;
    }

    public override void OnStart(int? numberOfTargets)
    {
        base.OnStart(numberOfTargets);
        this.numberOfTargets = numberOfTargets;
        Debug.Log($"Zadanie {questName} zostało rozpoczęte.\n{description}");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        numberOfTargets--;

        if (numberOfTargets == 0)
        {
            OnFinished();
        }
        else
        {
            Debug.Log($"Zostało jeszcze {numberOfTargets} czerwonych kostek do zebrania.");
        }      
    }

    public override void OnFinished()
    {
        base.OnFinished();
        Debug.Log($"Gratulacje zadanie '{questName}' zostało wykonanne :)");
    }
}
