using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuizzController : MonoBehaviour
{
    
    [SerializeField] private QuizzData _quizzData;

    [SerializeField] private GameObject _questionnaire;
    [SerializeField] private GameObject _goodAnswer;
    [SerializeField] private GameObject _wrongAnswer;

    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _questionText;


    [SerializeField] private float _animationDuration;
    private float _startAnimationTime;
    [SerializeField] private AnimationCurve _animationCurve;

    [SerializeField] private RectTransform _objectToAnim;


    public void onClickYes()
    {
        changeScreenToResult(true);
    }

    public void onClickNo()
    {
        changeScreenToResult(false);
    }

    public void changeScreenToResult(bool playerAnswer)
    {
        QuizzData.Question currentQuestion = _quizzData.getCurrentQuestion();

        _questionnaire.SetActive(false);

        if(playerAnswer == currentQuestion.answer)
        {
            _goodAnswer.SetActive(true);
            _quizzData.incrementScore();

            incrementAndUpdateScore();
        }
        else
        {
            _wrongAnswer.SetActive(true);

            StartCoroutine(PlayAnimation( _animationDuration, _animationCurve, _objectToAnim));
        }
    }

    public void onClickNextQuestion()
    {
        _quizzData.SwitchToNextQUestion();
        updateQuestion();
        _wrongAnswer.SetActive(false);
        _goodAnswer.SetActive(false);
        _questionnaire.SetActive(true);
    }

    public void incrementAndUpdateScore()
    {
        _scoreText.text = _quizzData.getScore() + " Points";
    }

    public void updateQuestion()
    {
        QuizzData.Question currentQuestion = _quizzData.getCurrentQuestion();
        _questionText.text = currentQuestion.questionText;
    }

    // Start is called before the first frame update
    void Start()
    {
        updateQuestion();
        incrementAndUpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator PlayAnimation(float duration, AnimationCurve animationCurve, RectTransform rectTransform )
    {
        _startAnimationTime = Time.time;

        float currentTime = Time.time;
        Vector3 startLocalScale = rectTransform.localScale;
        Vector3 startRotation = rectTransform.rotation.eulerAngles;


        while(_startAnimationTime + duration > currentTime)
        {
            currentTime = Time.time;

            float normalizeTime = (currentTime - _startAnimationTime) / duration;

            float factor = animationCurve.Evaluate(normalizeTime);

            rectTransform.localScale = startLocalScale * factor;
            
            rectTransform.rotation = Quaternion.Euler(startRotation + new Vector3(0, 0, factor * 180));

            yield return null;
        }

        rectTransform.localScale = startLocalScale;
        rectTransform.rotation = Quaternion.Euler(startRotation);

        yield return null;
    }
}
