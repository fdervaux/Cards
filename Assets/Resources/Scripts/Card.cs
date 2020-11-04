using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardColor
{
    Coeur = 2,
    Treffle = 0,
    Karreau = 1,
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
    [SerializeField]
    private bool _isFaceUp = true;

    private SpriteRenderer _spriteRenderer;
    private Container _container = null;
    private bool _initialized = false;

    public void setValue(int value)
    {
        _value = (CardValue)Mathf.Clamp(value, 0, 12);
        updateCard();
    }

    public void setColor(int color)
    {
        _color = (CardColor)Mathf.Clamp(color, 0, 3);
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


    public void setContainer(Container container)
    {
        _container = container;
    }

    public Container getContainer()
    {
        return _container;
    }

    public void randomize()
    {
        _color = (CardColor)Random.Range(0, 4);
        _value = (CardValue)Random.Range(0, 13);
        _isFaceUp = false;
        _isVisible = false;
    }

    public void randomize(char desc)
    {

        switch (desc)
        {
            case 'C':
                _color = CardColor.Coeur;
                break;
            case 'T':
                _color = CardColor.Treffle;
                break;
            case 'K':
                _color = CardColor.Karreau;
                break;
            case 'P':
                _color = CardColor.Pique;
                break;
            default:
                throw new System.ArgumentException("invalid card " + desc);
        }

        _value = (CardValue)Random.Range(0, 13);
        _isFaceUp = true;
        _isVisible = true;
    }



    private void updateCard()
    {
        if(_initialized)
        {
            GameManager gameManager = GameManager.Instance();

            int cardIndex = 0;
            int colorIndex = 0;

            switch (_color) 
            {
                case CardColor.Coeur:
                    colorIndex = 0;
                    break;
                case CardColor.Treffle:
                    colorIndex = 1;
                    break;
                case CardColor.Karreau:
                    colorIndex = 2;
                    break;
                case CardColor.Pique:
                    colorIndex = 3;
                    break;
                default:
                    colorIndex = 0;
                    break;
            }

            if (_isFaceUp)
                cardIndex = colorIndex * 14 + (((int)_value) + 1);

            if (gameManager != null && _isVisible)
                _spriteRenderer.sprite = gameManager.getCardSprite(cardIndex);
            else
                _spriteRenderer.sprite = null;
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

    void Start()
    {
        _initialized = true;
        updateCard();
    }

    void Update()
    {
    }

    private void OnValidate()
    {
        updateCard();
    }

}
