using Game.Quiz.Scripts;

namespace Assets.Game.Scripts
{
    public class QuizPanelGenerator
    {
        
        private QuizPanelModel _quizPanelModel;

        public QuizPanelGenerator(QuizElementConfig quizElementConfig, int level)
        {
            AnswerModel[] answersModel = new AnswerModel[]
            {
                new AnswerModel(quizElementConfig.Answers[0], true),
                new AnswerModel(quizElementConfig.Answers[1], false),
                new AnswerModel(quizElementConfig.Answers[2], false)
            };
            _quizPanelModel = new QuizPanelModel($"Level {level}", level, quizElementConfig.QuestionSprite, answersModel);
        }
        public QuizPanelModel GetQuizPanel() => _quizPanelModel;
        
    }
}
