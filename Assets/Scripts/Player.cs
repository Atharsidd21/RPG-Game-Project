using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine stateMachine ;
    private EntityState IdleState;
    private void Awake()
    {
        stateMachine = new StateMachine();
        IdleState = new EntityState(stateMachine, "Idle State");
    }
    private void Start()
    {
        stateMachine.Initialize(IdleState);

    }
    private  void Update()
    {
        stateMachine.currentState.Update();
    }
}
