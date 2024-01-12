using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Spin
{
    public class SpinsCountView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _spinsCount;

        public void UpdateSpinsCount(int spinsCount)
        {
            _spinsCount.text = "x " + spinsCount;
        }
    }
}
