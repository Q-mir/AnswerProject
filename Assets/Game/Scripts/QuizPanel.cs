using Assets.Game.Scripts;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuizPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelTextUI;
    [SerializeField] private TextMeshProUGUI _questionTextUI;
    [SerializeField] private Image _questionImage;
    [SerializeField] private AnswerPanel _answerPanel;
    private QuizPanelModel QuizPanelModel;
    public event Action<bool, int> OnSelectAnswer;
    public void Init(QuizPanelModel quizPanelModel)
    {
        OnSelectAnswer += SelectAnswer;
        QuizPanelModel = quizPanelModel;
        _levelTextUI.text = quizPanelModel.Leveltext;
        _questionTextUI.text = quizPanelModel.QuestionText;
        _questionImage.sprite = quizPanelModel.AnswerImage;
        _answerPanel.Init(quizPanelModel.Answers, OnSelectAnswer);
    }

    
    private void SelectAnswer(bool arg1, int arg2)
    {
        Debug.Log($"Select {arg1} : {arg2}");
    }

    private void Start()
    {
        AnswerModel[] answer = new AnswerModel[3];
        answer[0] = new AnswerModel("Answer 1", true);
        answer[1] = new AnswerModel("Answer 2", false);
        answer[2] = new AnswerModel("Answer 3", false);



        QuizPanelModel quizPanelModel = new("Level 11", "Answer 1", null, answer);
        Init(quizPanelModel);
    }

    
}



