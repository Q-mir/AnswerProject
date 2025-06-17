using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class Answer : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI _answerTextUI;
    [SerializeField] private Button _button;

    private AnswerModel _answerModel;
    private bool _isCorrect;
    private int _index;

    private event Action<int, bool> OnClick;

    public void Init(AnswerModel answerModel, int i, Action<int, bool> onSelectAnswer) {
        OnClick = onSelectAnswer;
        _index = i;
        _answerModel = answerModel;
        _answerTextUI.text = _answerModel.AnswerText;
        _isCorrect = _answerModel.IsCorrect;
        _button.onClick.AddListener(ButtonClick);
    }

    private void ButtonClick() {
        OnClick?.Invoke(_index, _isCorrect);
    }

    public void Disable() {
        _button.onClick.RemoveAllListeners();
    }
}