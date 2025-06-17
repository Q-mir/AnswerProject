using UnityEngine;

namespace Game.Quiz.Scripts {
    [CreateAssetMenu(fileName = "QuizLevelConfig", menuName = "MySo/Quiz/QuizLevelConfig")]
    public class QuizLevelConfig : ScriptableObject {
        [SerializeField] private QuizElementConfig[] _quizElementConfigs;
        public int QuizElementConfigsCount => _quizElementConfigs.Length;

        public QuizElementConfig GetElementByIndex(int index) {
            return _quizElementConfigs[index];
        }
    }
}

//Заполнить левел конфиг 10ю элемент конфигами