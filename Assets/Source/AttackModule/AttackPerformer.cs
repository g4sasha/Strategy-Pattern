using UnityEngine;

namespace AttackModule
{
    public class AttackPerformer
    {
        public void Attack(IAttackPerformer attack, Animator animator)
        {
            attack.Attack(animator);
        }
    }
}