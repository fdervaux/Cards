using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CardStateAnimation
{
    public Card card;
    public bool isVisible;
    public bool isFaceUp;
    public Vector3 Position;
    public int Layer;
}

public class GameManager : Container
{

    [SerializeField]
    private string _cardTexturePath;

    private Sprite[] _cardSprites;

    private static GameManager _instance = null;

    [SerializeField]
    private GameObject _card;

    [SerializeField]
    private List<Deck> _decks =  new List<Deck>();

    private List<CardStateAnimation> _cardAnimations = new List<CardStateAnimation>();

    [SerializeField]
    private float _animationDuration = 0.5f;

    [SerializeField]
    private AnimationCurve _animationCurve;

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }

        _cardSprites = Resources.LoadAll<Sprite>(_cardTexturePath);

        for (int i = 0; i < _decks.Count; i++)
        {

            for (int j = 0; j < 5; j++)
            {
                Card card = GameObject.Instantiate(_card, _decks[i].transform).GetComponent<Card>();
                card.randomize();
                _decks[i].Add(card);
            }
            _decks[i].initCardPosition();
        }
    }

    public static GameManager Instance()
    {
        return _instance;
    }

    public Sprite getCardSprite(int cardInt)
    {
        return _cardSprites[cardInt];
    }


    public new void Add(Card card)
    {
        base.Add(card);
        card.setVisible(false);
    }

    void Update()
    {
        
    }

    public void moveCard(Deck from, Deck to)
    {
        Card card = from.getTopCard();
        to.Add(card);
        _cardAnimations.Add(to.getTopCardInfos());
    }

    void Start()
    {
        moveCard(_decks[0], _decks[1]);
        moveCard(_decks[0], _decks[1]);
        moveCard(_decks[0], _decks[1]);
        moveCard(_decks[3], _decks[2]);

        playNextAnimation();
    }

    private void playNextAnimation()
    {
        if( _cardAnimations.Count > 0)
        {
            CardStateAnimation cardStateAnimation = _cardAnimations[0];
            _cardAnimations.RemoveAt(0);
            StartCoroutine(playCardAnimation( cardStateAnimation, playNextAnimation));
        }
    }


    IEnumerator playCardAnimation(CardStateAnimation cardStateAnimation, System.Action callBack)
    {
        float currentTime = 0;
        Vector3 startPosition = cardStateAnimation.card.transform.position;
        Vector3 endPosition = cardStateAnimation.Position;

        cardStateAnimation.card.SetLayer(1, SortingLayer.NameToID("Animation"));

        while(currentTime < _animationDuration)
        {
            float factor = currentTime / _animationDuration;
            factor = _animationCurve.Evaluate(factor);

            cardStateAnimation.card.transform.position = Vector3.Lerp(startPosition, endPosition, factor);

            currentTime += Time.deltaTime;
            yield return null;
        }

        cardStateAnimation.card.transform.position = endPosition;
        cardStateAnimation.card.SetLayer(cardStateAnimation.Layer, SortingLayer.NameToID("Deck"));

        callBack();

    }
}
