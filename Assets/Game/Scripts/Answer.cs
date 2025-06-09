using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Game.Scripts
{
    public class Answer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _answerTextUI;
        [SerializeField] private Button _answerButton;

        private int _answerIndex;
        private bool _isСorrect;

        public event Action<bool, int> OnClickAction;

        public void Init(AnswerModel answerModel, int index, Action<bool,int> OnSelectAnswer)
        {
            OnClickAction = OnSelectAnswer;
            _answerTextUI.text = answerModel.AnswerText;
            _answerIndex = index;
            _answerButton.onClick.AddListener(AnswerClick);
            
        }

        private void AnswerClick()
        {
            OnClickAction?.Invoke(_isСorrect, _answerIndex);
        }
    }
}