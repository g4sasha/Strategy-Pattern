using UnityEngine;

namespace Kotolazer.Client
{
    public class AttackPerformer
    {
        public void Attack(IAttackPerformer attack)
        {
            attack.Attack();
        }
    }

    public interface IAttackPerformer
    {
        void Attack();
    }

    public class FirstAttack : IAttackPerformer
    {
        public void Attack()
        {
            Debug.Log("First atack");
        }
    }

    public class SecondAttack : IAttackPerformer
    {
        public void Attack()
        {
            Debug.Log("Second atack");
        }
    }

    public class ThirdAttack : IAttackPerformer
    {
        public void Attack()
        {
            Debug.Log("Third attack");
        }

    }
}