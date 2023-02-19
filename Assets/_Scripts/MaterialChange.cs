using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    [SerializeField]
    GameObject _card;

    [SerializeField]
    Texture[] _textues;
    [SerializeField]
    Texture[] _masks;

    Material[] _changeMaterial = new Material[3];

    private void Awake()
    {
        _changeMaterial[0] = GetComponent<MeshRenderer>().materials[0];
        _changeMaterial[1] = GetComponent<MeshRenderer>().materials[1];
        _changeMaterial[2] = GetComponent<MeshRenderer>().materials[2];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
