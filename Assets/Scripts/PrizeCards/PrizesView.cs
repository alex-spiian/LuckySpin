using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrizesView : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _goldCount;
   [SerializeField] private TextMeshProUGUI _gemsCount;
   [SerializeField] private TextMeshProUGUI _lifesCount;
   [SerializeField] private TextMeshProUGUI _mysteryCardsCount;


   public void UpdatePrizesCount(int gold, int gems, int life, int mysteryCards)
   {
      _goldCount.text = "x " + gold;
      _gemsCount.text = "x " + gems;
      _lifesCount.text = "x " + life;
      _mysteryCardsCount.text = "x " + mysteryCards;
   }
}
