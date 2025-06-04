using Assets.Game.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelTextUI;
    [SerializeField] private TextMeshProUGUI _questionTextUI;
    [SerializeField] private Image _questionImage;
    [SerializeField] private AnswerPanel _answerPanel;
    public void Init()
    {
        _answerPanel.AnswerAdded += ShowDebug;
        var arr = new AnswerModel[3];
        arr[0] = new AnswerModel("One", true);
        arr[1] = new AnswerModel("Two", false);
        arr[2] = new AnswerModel("Three", false);

        _answerPanel.Init(arr);
    }

    private void Start()
    {
        Init();
    }

    private void ShowDebug(bool isCorrect, int index)
    {
        Debug.Log($"QuizPanel: нажал кнопку с индексом {index} ");
    }
}
