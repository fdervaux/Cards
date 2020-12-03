using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuizzData
{
    [System.Serializable]
    public struct Question
    {
        public string questionText;
        public bool answer;
    }

    [SerializeField] private List<Question> _questions = new List<Question>();

    private int _currentQuestionIndex = 0;

    private int _score = 0;

    public void AddQuestion(Question question)
    {
        _questions.Add(question);
    }

    public void AddQuestion(string questionText, bool answer)
    {
        Question question;
        question.questionText = questionText;
        question.answer = answer;
        AddQuestion(question);
    }

    public Question getCurrentQuestion()
    {
        if(_questions.Count >0)
        {
            return _questions[_currentQuestionIndex];
        }
        else
        {
            Question question;
            question.questionText = "No question, please add question";
            question.answer = true;
            return question;
        }
    }

    public void SwitchToNextQUestion()
    {
        _currentQuestionIndex++;
        if( _currentQuestionIndex >= _questions.Count)
        {
            _currentQuestionIndex = 0;
        }
    }

    public int getScore()
    {
        return _score;
    }

    public void incrementScore()
    {
        _score++;
    }

}