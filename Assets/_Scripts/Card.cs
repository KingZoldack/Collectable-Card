using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField]
    int _cardSlot;

    CardInfo _cardInfo;

    [SerializeField]
    TextMeshPro _descriptionBoxText;

    public int CardSlot { get { return _cardSlot; } set { _cardSlot = value; } }

    private void Awake()
    {
        _cardInfo = GameObject.FindObjectOfType<CardInfo>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SetName();
    }

    // Update is called once per frame
    void Update()
    {
        SetName();
    }

    private void SetName()
    {
        if (this.gameObject.tag == "Common")
        _descriptionBoxText.text = _cardInfo.commonCardNames[_cardSlot];

        if (this.gameObject.tag == "Rare")
            _descriptionBoxText.text = _cardInfo.rareCardNames[_cardSlot];

        if (this.gameObject.tag == "Legendary")
            _descriptionBoxText.text = _cardInfo.legendaryCardNames[_cardSlot];
    }
}
