using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tastAnime : StateMachineBehaviour
{
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    //OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (  Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Q) || (Input.GetKey(KeyCode.Z) && !(Input.GetKey(KeyCode.LeftShift))) )
        {
            animator.SetBool("walk", true);
        }
        else if (!(Input.GetKey(KeyCode.S)))
        {
            animator.SetBool("walk", false);

        }

        if (Input.GetKey(KeyCode.S) )
        {
            animator.SetBool("move back", true);
        }
        else if(!(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Q) ))
        {
            animator.SetBool("move back", false);

        }

        if (Input.GetKey(KeyCode.Z)  /*|| Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Q)*/ && Input.GetKey(KeyCode.LeftShift) )
        {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);

        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);

        }

        if (Input.GetKey(KeyCode.P))
        {
            animator.SetBool("die", true);
        }

    }

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}
}
