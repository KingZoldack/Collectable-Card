using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    GameObject _card;

    [SerializeField]
    Texture[] _commonTextues;
    [SerializeField]
    Texture[] _rareTextues;
    [SerializeField]
    Texture[] _legendaryTextues;

    [SerializeField]
    Texture[] _legendaryMasks;

    Material[] _changeMaterial = new Material[3];

    private void Awake()
    {
        _card = transform.root.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        _changeMaterial[0] = GetComponent<MeshRenderer>().materials[0];
        _changeMaterial[1] = GetComponent<MeshRenderer>().materials[1];
        _changeMaterial[2] = GetComponent<MeshRenderer>().materials[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (_card.tag == "Common")
            _changeMaterial[1].SetTexture("_CommonCardFront", _commonTextues[_card.GetComponent<Card>().CardSlot]);

        if (_card.tag == "Rare")
            _changeMaterial[1].SetTexture("_RareCardFront", _rareTextues[_card.GetComponent<Card>().CardSlot]);

        if (_card.tag == "Legendary")
        {
            _changeMaterial[1].SetTexture("_LegendaryCardFront", _legendaryTextues[_card.GetComponent<Card>().CardSlot]);
            _changeMaterial[1].SetTexture("_LegendaryMask", _legendaryMasks[_card.GetComponent<Card>().CardSlot]);
        }
    }
}
