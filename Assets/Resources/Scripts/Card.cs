using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardColor
{
    Coeur = 0,
    Treffle = 1,
    Carreau = 2,
    Pique = 3,
}

public enum CardValue
{
    Deux = 0,
    Trois = 1,
    Quatre = 2,
    Cinq = 3,
    Six = 4,
    Sept = 5,
    Huit = 6,
    Neuf = 7,
    Dix = 8,
    Valet = 9,
    Dame = 10,
    Roi = 11,
    As = 12,
}

public class Card : MonoBehaviour
{

    [SerializeField]
    private CardValue _value;
    [SerializeField]
    private CardColor _color;
    [SerializeField]
    private bool _isVisible = false;
    private bool _isFaceUp = true;

    private SpriteRenderer _spriteRenderer;
    private Container _container = null;

    public void setValue(int value)
    {
        _value = (CardValue) Mathf.Clamp(value,0,12);
        updateCard();
    }

    public void setColor(int color)
    {
        _color = (CardColor) Mathf.Clamp(color,0,3);
        updateCard();
    }
    public void setVisible(bool visible)
    {
        _isVisible = visible;
        updateCard();
    }

    public void setFaceUp(bool faceUp)
    {
        _isFaceUp = faceUp;
        updateCard();
    }

    public CardColor getColor()
    {
        return _color;
    }

    public CardValue getValue()
    {
        return _value;
    }

    public bool isVisible()
    {
        return _isVisible;
    }

    public bool isFaceUp()
    {
        return _isFaceUp;
    }


    public void setContainer( Container container)
    {
        _container = container;
    }

    public Container getContainer()
    {
        return _container;
    }

    public void randomize()
    {
        _color = (CardColor) Random.Range(0, 4);
        _value = (CardValue) Random.Range(0, 13);
        _isFaceUp = true;
        _isVisible = true;
    }

    private void updateCard()
    {
        GameManager gameManager = GameManager.Instance();
        if(gameManager != null)
        {
            int cardIndex = 0;

            if (_isFaceUp)
                cardIndex = ((int)_color) * 14 + (((int)_value) + 1);


            _spriteRenderer.enabled = _isVisible;

            if (gameManager != null)
                _spriteRenderer.sprite = gameManager.getCardSprite(cardIndex);
        }  
    }

    public void SetLayer(int layer, int sortingLayerID)
    {
        _spriteRenderer.sortingOrder = layer;
        _spriteRenderer.sortingLayerID = sortingLayerID;
    }
    

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void start()
    {
        updateCard();
    }

    void Update()
    {
    }

    private void OnValidate() {
        updateCard();
    }

}
