using Kotolazer.InputSystem;
using UnityEngine;

namespace Kotolazer.Client
{
    [RequireComponent(typeof(Animator))]
    public class Client : MonoBehaviour
    {
        [SerializeField] private DesktopInput _input;
        [SerializeField] private Animator _animator;
        private AttackPerformer _performer;
        private AttackType _attackType;

        private void OnValidate() => _animator ??= GetComponent<Animator>();

        private void Awake() => _performer = new AttackPerformer();

        private void OnEnable() => _input.OnAttack += Attack;

        private void OnDisable() => _input.OnAttack -= Attack;

        public void SetAtackType(AttackType atackType) => _attackType = atackType;

        private void Attack()
        {
            switch (_attackType)
            {
                case AttackType.First:
                    _performer.Attack(new FirstAttack(), _animator);
                    break;
                case AttackType.Second:
                    _performer.Attack(new SecondAttack(), _animator);
                    break;
                case AttackType.Third:
                    _performer.Attack(new ThirdAttack(), _animator);
                    break;
            }
        }
    }
}