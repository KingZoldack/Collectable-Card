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
        _descriptionBoxText.text = _cardInfo._cardNames[_cardSlot];
    }
}
