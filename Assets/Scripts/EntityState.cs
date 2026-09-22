using UnityEngine;

public class EntityState 

{
    protected StateMachine stateMachine;
    protected string StateName;

    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.StateName = stateName;
    }
    public virtual void Enter ()
    {
        Debug.Log("I am entering the state: " + StateName);
    }
    public virtual void Update ()
    {
        Debug.Log("I am updating the state: " + StateName);
    }
    public virtual void Exit()
    {
        Debug.Log("I am exiting the state: " + StateName);
    }
}
