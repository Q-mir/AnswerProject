using Game.Quiz.Scripts;
using UnityEngine;

namespace Assets.Game.Quiz.Scripts
{
    public class GameEntryPoint : MonoBehaviour
    {
        [SerializeField] private QuizLevelConfig quizLevelConfig;
        [SerializeField] private QuizPanel quizPanel;

        public void Start()
        {
            Init();
        }

        private void Init()
        {
            int level = Random.Range(0, quizLevelConfig.QuizElementConfigsCount);
            QuizElementConfig quizElementConfig = quizLevelConfig.GetElementByIndex(level);
            QuizPanelModel quizPanelModel = QuizGeneratorLevelByConfig.GetQuizPanelModel(quizElementConfig, level);
            quizPanel.Init(quizPanelModel);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Init();
            }
        }


    }
}