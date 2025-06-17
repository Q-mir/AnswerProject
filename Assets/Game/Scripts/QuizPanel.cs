using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class QuizPanel : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _levelLabelTextUI;
    [SerializeField] private TextMeshProUGUI _quizQuestionTextUI;
    [SerializeField] private Image _questionImageUI;
    [SerializeField] private AnswerPanel _answerPanel;
    public event Action<int, bool> OnSelectAnswer;

    public void Init(QuizPanelModel quizPanelModel) {
        OnSelectAnswer += SelectAnswer;
        _levelLabelTextUI.text = $"Level {quizPanelModel.LevelIndex + 1}";
        _quizQuestionTextUI.text = quizPanelModel.QuestionText;
        _questionImageUI.sprite = quizPanelModel.Sprite;
        _answerPanel.Init(quizPanelModel.AnswerModels, OnSelectAnswer);
    }

    private void SelectAnswer(int arg1, bool arg2) {
        OnSelectAnswer = null;
        _answerPanel.DisableButton();
        Debug.Log($"Secelt {arg1},{arg2}");
    }
}


//Заблокировать нажатия на кнопку, при нажатии на любую кнопку