using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {

        public Action<int> OnSpinsCountChanged;
        private int _spinsCount = 3;

        private void Awake()
        {
            OnSpinsCountChanged?.Invoke(_spinsCount);
        }

        public void SpendSpin()
        {
            _spinsCount--;
            
            OnSpinsCountChanged?.Invoke(_spinsCount);
        }

        public int GetSpinsCount()
        {
            return _spinsCount;
        }

    }
}