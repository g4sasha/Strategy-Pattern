using System.Collections.Generic;
using AttackModule;
using InputSystem;
using UnityEngine;

namespace Client
{
    [RequireComponent(typeof(Animator))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private DesktopInput _input;
        [SerializeField] private Animator _animator;
        private AttackPerformer _performer;
        private AttackType _attackType;
        private List<IAttackPerformer> _attackPerformers;

        private void OnValidate() => _animator ??= GetComponent<Animator>();

        public void Construct(List<IAttackPerformer> attackPerformers) 
        {
            _performer = new AttackPerformer();
            _attackPerformers = attackPerformers;
        }

        private void OnEnable() => _input.OnAttack += Attack;

        private void OnDisable() => _input.OnAttack -= Attack;

        public void SetAtackType(AttackType atackType) => _attackType = atackType;

        private void Attack()
        {
            switch (_attackType)
            {
                case AttackType.First:
                    _performer.Attack(_attackPerformers[0], _animator);
                    break;
                case AttackType.Second:
                    _performer.Attack(_attackPerformers[1], _animator);
                    break;
                case AttackType.Third:
                    _performer.Attack(_attackPerformers[2], _animator);
                    break;
            }
        }
    }
}