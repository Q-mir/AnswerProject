﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Game.Scripts
{
    public struct AnswerModel
    {
        public AnswerModel(string answerText, bool isCorrect)
        {
            AnswerText = answerText;
            this.IsCorrect = isCorrect;
        }

        public string AnswerText { get; }
        public bool IsCorrect { get; }

    }
}
