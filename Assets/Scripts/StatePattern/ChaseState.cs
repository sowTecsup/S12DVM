using UnityEngine;

public class ChaseState : IState
{
    private StateMachine stateMachine;
    private EnemyController enemyController;

    public ChaseState(StateMachine stateMachine, EnemyController enemyController)
    {
        this.stateMachine = stateMachine;
        this.enemyController = enemyController;
    }

    public void Enter()
    {
        
    }
    public void Update()
    {

    }

    public void Exit()
    {
       
    }

    
}
