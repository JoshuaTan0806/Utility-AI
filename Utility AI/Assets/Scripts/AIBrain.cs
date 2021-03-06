using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AIStats))]
public class AIBrain : MonoBehaviour
{
    public Action currentAction;
    public List<Action> Actions;
    AIStats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<AIStats>();

        currentAction = ChooseBestAction();
        currentAction.InitialiseAction(stats);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentAction.IsActionComplete())
        {
            currentAction = ChooseBestAction();
            currentAction.InitialiseAction(stats);
        }

        currentAction.ExecuteAction(stats);
    }

    Action ChooseBestAction()
    {
        float BestScore = 0;
        Action BestAction = Actions[0];

        for (int i = 0; i < Actions.Count; i++)
        {
            float score = Actions[i].ScoreAction(stats);

            if(score > BestScore)
            {
                BestScore = score;
                BestAction = Actions[i];
            }
        }

        return BestAction;
    }
}
