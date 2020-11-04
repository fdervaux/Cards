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

    // static variable
    private static GameManager _instance = null;

    //unity options
    [SerializeField]
    private string _cardTexturePath;

    [SerializeField]
    private Vector3 _dealPosition;

    [SerializeField]
    private GameObject _card;

    [SerializeField]
    private List<Deck> _decks = new List<Deck>();

    [SerializeField]
    private Deck _discardDeck;

    [SerializeField]
    private Deck _dealDeck;

    [SerializeField]
    private float _animationDuration = 0.5f;

    [SerializeField]
    private AnimationCurve _animationCurve;

    [SerializeField]
    private int _maxRandomCard = 5;

    //private variables
    private Sprite[] _cardSprites;
    private List<CardStateAnimation> _cardAnimations = new List<CardStateAnimation>();

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
    }

    public void StartAnimation()
    {
        playNextAnimation();
    }

    void Start()
    {
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
        cardStateAnimation.card.setVisible(cardStateAnimation.isVisible);
        cardStateAnimation.card.setFaceUp(cardStateAnimation.isFaceUp);

        callBack();
    }


    public void InitDeck(Deck deck, string description)
    {
        discardDeck(deck);
        description = DescriptionCardParser.parse(description,_maxRandomCard);

        List<Card> cardsToAdd = new List<Card>();

        for (int i = 0; i < description.Length; i++)
        {
            Card card = GameObject.Instantiate(_card, deck.transform).GetComponent<Card>();
            card.randomize(description[i]);
            cardsToAdd.Add(card);
            _dealDeck.Add(card);
        }

        _dealDeck.initCardPosition();

        foreach (Card card in cardsToAdd)
        {
            deck.Add(card);
            _cardAnimations.Add(deck.getTopCardInfos());
        }
    }

    public void discardDeck(Deck deck)
    {
        while( !deck.isEmpty())
        {
            MoveTopCard(deck, _discardDeck);
        }
    }

    public void MoveTopCard(Deck from, Deck to)
    {
        Card card = from.getTopCard();
        to.Add(card);
        _cardAnimations.Add(to.getTopCardInfos());
    }

    public bool DeckIsEmpty(Deck deck)
    {
        return deck.isEmpty();
    }

    public CardColor topCardColor(Deck deck)
    {
        if( deck.isEmpty())
        {
            throw new System.ArgumentOutOfRangeException("Deck " + deck.name + " Is Empty !");
        }
        return deck.getTopCard().getColor();
    }



    public bool Superior(Deck deck1, Deck deck2)
    {
        if (deck1.isEmpty())
        {
            throw new System.ArgumentOutOfRangeException("Deck " + deck1.name + " Is Empty !"); ;
        }
        if (deck2.isEmpty())
        {
            throw new System.ArgumentOutOfRangeException("Deck " + deck2.name + " Is Empty !");
        }

        if (deck1.getTopCard().getValue() > deck2.getTopCard().getValue())
            return true;

        if (deck1.getTopCard().getValue() == deck2.getTopCard().getValue())
        { 
            if (deck1.getTopCard().getColor() > deck2.getTopCard().getColor())
                return true;
        }

        return false;
    }


}
