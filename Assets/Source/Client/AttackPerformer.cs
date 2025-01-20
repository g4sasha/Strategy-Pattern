using UnityEngine;

namespace Kotolazer.Client
{
    public class AttackPerformer
    {
        public void Attack(IAttackPerformer attack, Animator animator)
        {
            attack.Attack(animator);
        }
    }

    public interface IAttackPerformer
    {
        void Attack(Animator animator);
    }

    public class FirstAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            Debug.Log("First atack");
            animator.SetTrigger("FirstAttack");
            Debug.Log("Cmptest");
        }
    }

    public class SecondAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            Debug.Log("Second atack");
            animator.SetTrigger("SecondAttack");
        }
    }

    public class ThirdAttack : IAttackPerformer
    {
        public void Attack(Animator animator)
        {
            Debug.Log("Third attack");
            animator.SetTrigger("ThirdAttack");
        }

    }
}