﻿using System;
using System.Collections;
using UnityEngine;

namespace Assets.Game.Scripts
{
    public class AnswerPanel : MonoBehaviour
    {
        private Answer[] _answers;

        
        public void Init(AnswerModel[] answersModels, Action<bool, int> OnSelectAnswer)
        {
            _answers = transform.GetComponentsInChildren<Answer>();

            for (int i = 0; i < _answers.Length; i++)
            {
                Answer currentElement = _answers[i];
                currentElement.Init(answersModels[i], i, OnSelectAnswer);
            }

        }

        public void Disable()
        {
            for (int i = 0; i < _answers.Length; i++)
            {
                _answers[i].Disable();
            }
        }
    }
}