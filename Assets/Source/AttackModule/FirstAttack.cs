using UnityEngine;

namespace AttackModule
{
    public class FirstAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger(AttackAnimationsTrigger.FirstAttackTrigger);
        }
    }
}