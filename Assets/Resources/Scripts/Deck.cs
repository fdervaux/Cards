using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Container
{
    [SerializeField]
    private Vector3 _displacement = new Vector3(0.1f, 0.1f, 0.0f);

    [SerializeField]
    private bool _isDeal = false;

    private int _cardCount = 0;

    public new void Add(Card card)
    {
        if(_isDeal)
            _cardCount++;
        base.Add(card);
    }
    

    public void initTopCard()
    {
        int topCardIndex = _cards.Count - 1;
        _cards[topCardIndex].transform.position = transform.position + topCardIndex * _displacement;
        _cards[topCardIndex].SetLayer(topCardIndex, SortingLayer.NameToID("Deck"));
    }

    public Card getTopCard()
    {
        return _cards[_cards.Count - 1];
    }

    public void initCardPosition()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            int index = _isDeal?(_cardCount - _cards.Count + i):i;
            _cards[i].transform.position = transform.position + index * _displacement;
            _cards[i].SetLayer(index, SortingLayer.NameToID("Deck"));
        }
    }

    public CardStateAnimation getTopCardInfos()
    {
        CardStateAnimation cardStateAnimation;
        cardStateAnimation.isFaceUp = true;
        cardStateAnimation.isVisible = true;
        cardStateAnimation.Position = transform.position + (_cards.Count - 1) * _displacement;
        cardStateAnimation.Layer = _cards.Count - 1;
        cardStateAnimation.card = getTopCard();
        return cardStateAnimation;
    }

}