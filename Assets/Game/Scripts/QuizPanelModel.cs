using System.Collections;
using UnityEngine;

namespace Assets.Game.Scripts
{
    public class QuizPanelModel
    {
        public string Leveltext { get; }
        public string QuestionText { get; }
        public Sprite AnswerImage { get; }
        public AnswerModel[] Answers { get; }

        public QuizPanelModel(string leveltext, string questionText, Sprite answerImage, AnswerModel[] answers)
        {
            this.Leveltext = leveltext;
            this.QuestionText = questionText;
            this.AnswerImage = answerImage;
            this.Answers = answers;
        }
    }
}