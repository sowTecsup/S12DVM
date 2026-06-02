using UnityEngine;

public class AttackState : IState
{
    private StateMachine stateMachine;
    private EnemyController enemyController;

    public AttackState(StateMachine stateMachine, EnemyController enemyController)
    {
        this.stateMachine = stateMachine;
        this.enemyController = enemyController;
    }

    public void Enter()
    {
        
    }

    public void Exit()
    {
       
    }

    public void Update()
    {
       
    }
}
