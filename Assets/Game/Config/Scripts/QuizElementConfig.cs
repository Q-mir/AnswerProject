using UnityEngine;

namespace Game.Quiz.Scripts {
    [CreateAssetMenu(fileName = "QuizElementConfig", menuName = "MySo/Quiz/QuizElementConfig")]
    public class QuizElementConfig : ScriptableObject {
        [field: SerializeField] public Sprite QuestionSprite { get; private set; }
        [field: SerializeField] public string QuestionText { get; private set; }
        [field: SerializeField] public string[] Answers { get; private set; }
    }
}