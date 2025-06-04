using System;
using System.Collections;
using UnityEngine;

namespace Assets.Game.Scripts
{
    public class AnswerPanel : MonoBehaviour
    {
        private Answer[] _answers;

        public event Action<bool, int> AnswerAdded;
        public void Init(AnswerModel[] answersModels)
        {
            _answers = transform.GetComponentsInChildren<Answer>();

            for (int i = 0; i < _answers.Length; i++)
            {
                _answers[i].Init(answersModels[i], i);
                _answers[i].OnClickAction += Click;
            }

        }

        public void Click(bool isCorrect, int index)
        {
            AnswerAdded?.Invoke(isCorrect, index);
        }



        


        

    }
}