using UnityEngine;

namespace AttackModule
{
    public class SecondAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger(AttackAnimationsTrigger.SecondAttackTrigger);
        }
    }
}