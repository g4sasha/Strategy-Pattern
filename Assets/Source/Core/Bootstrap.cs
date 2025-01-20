using System.Collections.Generic;
using AttackModule;
using Client;
using UnityEngine;

namespace Core
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private readonly List<IAttackPerformer> _attackPerformers = new();

        private void Start()
        {
            _attackPerformers.Add(new FirstAttack());
            _attackPerformers.Add(new SecondAttack());
            _attackPerformers.Add(new ThirdAttack());

            _player.Construct(_attackPerformers);
        }
    }
}