using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackingState : EnemyBaseState
{
    private readonly int AttackHash = Animator.StringToHash("Attack");

    private const float TransitionDuration = 0.1f;

    public EnemyAttackingState(EnemyStateMachine stateMachine) : base(stateMachine){ }

    public override void Enter()
    {
        stateMachine.WeaponLeft.SetAttack(stateMachine.AttackDamage, stateMachine.AttackKnockback);
        stateMachine.WeaponRight.SetAttack(stateMachine.AttackDamage, stateMachine.AttackKnockback);

        stateMachine.Animator.CrossFadeInFixedTime(AttackHash, TransitionDuration);

        FacePlayer();
    }

    public override void Tick(float deltaTime)
    {
        if (GetNormalizedTime(stateMachine.Animator, "Attack") >= 1)
        {
            stateMachine.SwitchState(new EnemyChasingState(stateMachine));
        }
    }

    public override void Exit() { }
}
