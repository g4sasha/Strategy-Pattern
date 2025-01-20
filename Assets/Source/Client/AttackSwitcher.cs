using UnityEngine;
using UnityEngine.UI;

namespace Kotolazer.Client
{
    public class AttackSwitcher : MonoBehaviour
    {
        [SerializeField] private Dropdown _dropdown;
        [SerializeField] private Client _client;

        private void OnEnable()
        {
            _dropdown.onValueChanged.AddListener(i => _client.SetAtackType((AttackType)i));
        }

        private void OnDisable()
        {
            _dropdown.onValueChanged.RemoveListener(i => _client.SetAtackType((AttackType)i));
        }
    }
}