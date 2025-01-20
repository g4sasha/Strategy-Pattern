using System;
using UnityEngine;

namespace InputSystem
{
    public class DesktopInput : MonoBehaviour
    {
        public event Action OnAttack;

        private void Update()
        {
            HandleAttack();
        }

        private void HandleAttack()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                OnAttack?.Invoke();
            }
        }
    }
}