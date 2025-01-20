using Kotolazer.InputSystem;
using UnityEngine;

namespace Kotolazer.Client
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private DesktopInput _input;
        private AttackPerformer _performer;
        private AttackType _attackType;

        private void Awake() => _performer = new AttackPerformer();

        private void OnEnable() => _input.OnAttack += Attack;

        private void OnDisable() => _input.OnAttack -= Attack;

        public void SetAtackType(AttackType atackType) => _attackType = atackType;

        private void Attack()
        {
            switch (_attackType)
            {
                case AttackType.First:
                    _performer.Attack(new FirstAttack());
                    break;
                case AttackType.Second:
                    _performer.Attack(new SecondAttack());
                    break;
                case AttackType.Third:
                    _performer.Attack(new ThirdAttack());
                    break;
            }
        }
    }
}