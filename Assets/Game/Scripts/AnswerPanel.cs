using UnityEngine;
using System;

public class AnswerPanel : MonoBehaviour {
    private Answer[] _answers;

    public void Init(AnswerModel[] answers, Action<int, bool> onSelectAnswer) {
        _answers = transform.GetComponentsInChildren<Answer>();

        for (int i = 0; i < _answers.Length; i++) {
            Answer currentElement = _answers[i];
            currentElement.Init(answers[i], i, onSelectAnswer);
        }
    }

    public void DisableButton() {
        for (int i = 0; i < _answers.Length; i++) {
            Answer currentElement = _answers[i];
            currentElement.Disable();
        }
    }
}