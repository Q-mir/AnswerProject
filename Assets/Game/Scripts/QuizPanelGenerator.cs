using Assets.Game.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Game.Scripts
{
    public class QuizPanelGenerator
    {
        
        private QuizPanelModel _quizPanelModel;

        public QuizPanelGenerator(QuizElementCongif quizElementConfig, int level)
        {
            AnswerModel[] answersModel = new AnswerModel[]
            {
                new AnswerModel(quizElementConfig.Answers[0], true),
                new AnswerModel(quizElementConfig.Answers[1], false),
                new AnswerModel(quizElementConfig.Answers[2], false)
            };
            _quizPanelModel = new QuizPanelModel($"Level {level}", quizElementConfig.QuestionText, quizElementConfig.QuestionImage, answersModel);
        }
        public QuizPanelModel GetQuizPanel() => _quizPanelModel;
        
    }
}
