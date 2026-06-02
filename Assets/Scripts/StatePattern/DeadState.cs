using UnityEngine;

public class DeadState : IState
{
    private StateMachine stateMachine;
    private EnemyController enemyController;

    public DeadState(StateMachine stateMachine, EnemyController enemyController)
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
