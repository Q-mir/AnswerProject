using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
namespace Assets.Game.Scripts
{
	[CreateAssetMenu(fileName = "QuizElementConfig", menuName = "MySo/Quiz/QuizElementCongif")]
	public class QuizElementCongif : ScriptableObject
	{
        [field: SerializeField] public string QuestionText{ get; private set; }
        [field:SerializeField] public Sprite QuestionImage { get; private set; }
        [field:SerializeField] public string[] Answers { get; private set; }
    }
}