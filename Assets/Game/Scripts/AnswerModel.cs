public struct AnswerModel {
    public string AnswerText { get; private set; }
    public bool IsCorrect { get; }

    public AnswerModel(string answerText, bool isCorrect) {
        AnswerText = answerText;
        IsCorrect = isCorrect;
    }

    public void SetAnswerText(string answerText) {
        AnswerText = answerText;
    }
}