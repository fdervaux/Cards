using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Container
{
    [SerializeField]
    private Vector3 _displacement = new Vector3(0.1f, 0.1f, 0.0f);

    public new void Add(Card card)
    {
        base.Add(card);
        card.setVisible(true);
    }

    public Card getTopCard()
    {
        return _cards[_cards.Count - 1];
    }

    public void initCardPosition()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            _cards[i].transform.position = transform.position + i * _displacement;
            _cards[i].SetLayer(i, SortingLayer.NameToID("Deck"));
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