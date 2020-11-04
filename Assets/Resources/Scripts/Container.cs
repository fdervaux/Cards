using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Container : MonoBehaviour
{
    protected List<Card> _cards = new List<Card>();

    public void Add(Card card)
    {
        if(card.getContainer()!=null)
            card.getContainer().remove(card);
        card.setContainer(this);
        card.transform.SetParent(card.getContainer().transform);
        _cards.Add(card);
    }

    public bool isEmpty()
    {
        return _cards.Count == 0;
    }

    public void remove(Card card)
    {
        _cards.Remove(card);
    }

}
