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
        private bool _isСorrect;
        public event Action<bool> OnClick;

        public void Init(string answerText)
        {

        }
    }
}