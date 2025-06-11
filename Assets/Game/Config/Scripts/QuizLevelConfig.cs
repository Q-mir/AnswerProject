using Assets.Game.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Game.Config
{
    [CreateAssetMenu(fileName = "QuizLevelConfig", menuName = "MySo/Quiz/QuizLevelConfig")]
    public class QuizLevelConfig : ScriptableObject
    {
        [field: SerializeField] private QuizElementCongif[] _quizElementCongifs;
        public QuizElementCongif GetElementCongifByIndex(int index)
        {
            return _quizElementCongifs[index];
        }
    }
}
