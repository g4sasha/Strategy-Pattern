using Client;
using UnityEngine;
using UnityEngine.UI;

namespace AttackModule
{
    public class AttackSwitcher : MonoBehaviour
    {
        [SerializeField] private Dropdown _dropdown;
        [SerializeField] private Player _player;

        private void OnEnable()
        {
            _dropdown.onValueChanged.AddListener(i => _player.SetAtackType((AttackType)i));
        }

        private void OnDisable()
        {
            _dropdown.onValueChanged.RemoveListener(i => _player.SetAtackType((AttackType)i));
        }
    }
}