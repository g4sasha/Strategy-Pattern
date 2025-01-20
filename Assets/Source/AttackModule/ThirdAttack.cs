using UnityEngine;

namespace AttackModule
{
    public class ThirdAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger(AttackAnimationsTrigger.ThirdAttackTrigger);
        }

    }
}