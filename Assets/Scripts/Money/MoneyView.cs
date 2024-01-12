using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Money
{
    public class MoneyView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _gold;
        [SerializeField] private TextMeshProUGUI _gems;

        public void UpdateMoneyView(int gold, int gems)
        {
            var currentGold = Convert.ToInt32(_gold.text) + gold;
            var currentGems = Convert.ToInt32(_gems.text) + gems;

            _gold.text = currentGold.ToString();
            _gems.text = currentGems.ToString();
        }
    }
}
