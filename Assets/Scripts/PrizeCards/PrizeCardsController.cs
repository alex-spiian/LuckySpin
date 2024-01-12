using System;
using System.Collections.Generic;
using Arrow;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;

namespace PrizeCards
{
    
    [Serializable]
    public class PrizeCardsController : MonoBehaviour
    {
        public UnityEvent OnDarkScreenMode;
        
        [SerializeField] public GameObject[] _cards;
        [SerializeField] private ArrowController _arrowController;

        private Dictionary<string, int> _cardsCount;

        private void Awake()
        {
            InitializeCardsDictionary();
        }


        public void SwitchWonCardOn()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                if (_cards[i].transform.CompareTag(_arrowController.GetWonPrizeName))
                {
                    OnDarkScreenMode?.Invoke();

                    _cards[i].SetActive(true);

                    _cardsCount[_cards[i].tag] ++;

                }
            }
        }


        public void ResetCardsState()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i].SetActive(false);
            }
        }

        public int GetGoldCount()
        {
            _cardsCount.TryGetValue(GlobalConstants.GOLD_TAG, out var count);

            return count * GlobalConstants.GOLD_MULTIPLICATOR;
        }
        
        public int GetGemsCount()
        {
            _cardsCount.TryGetValue(GlobalConstants.GEM_TAG, out var count);

            return count * GlobalConstants.GEMS_MULTIPLICATOR;
        }
        
        public int GetLifeCount()
        {
            _cardsCount.TryGetValue(GlobalConstants.HEART_TAG, out var count);

            return count;
        }
        
        public int GetMysteryCardsCount()
        {
            _cardsCount.TryGetValue(GlobalConstants.RUNE_TAG, out var count);

            return count;
        }
        
        

        private void InitializeCardsDictionary()
        {

            _cardsCount = new Dictionary<string, int>();
            
            for (int i = 0; i < _cards.Length; i++)
            {
                _cardsCount.TryAdd(_cards[i].tag, 0);
            }
        }
        
        
    }
}