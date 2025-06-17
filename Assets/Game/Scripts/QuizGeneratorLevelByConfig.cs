using Game.Quiz.Scripts;


namespace Assets.Game.Quiz.Scripts
{
    public static class QuizGeneratorLevelByConfig
    {
        public static QuizPanelModel GetQuizPanelModel(QuizElementConfig quizElementConfig, int level)
        {
            AnswerModel[] answerModel = new AnswerModel[quizElementConfig.Answers.Length];
            for (int i = 0; i < answerModel.Length; i++)
            {
                answerModel[i] = new AnswerModel(quizElementConfig.Answers[i], i == 0);
            }
            return new QuizPanelModel(quizElementConfig.QuestionText, level, quizElementConfig.QuestionSprite, answerModel);
        }
    }
}


//public class QuizElementConfig : ScriptableObject
//{
//    [field: SerializeField] public Sprite QuestionSprite { get; private set; }
//    [field: SerializeField] public string QuestionText { get; private set; }
//    [field: SerializeField] public string[] Answers { get; private set; }
//}
//}