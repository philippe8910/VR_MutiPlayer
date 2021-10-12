using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagermemt : MonoBehaviour
{
    [SerializeField] public  GameObject Head;

    [SerializeField] public  GameObject RightHand;
    
    [SerializeField] public  GameObject LeftHand;

    public static PlayerManagermemt instance;

    private void Awake()
    {
        instance = this.GetComponent<PlayerManagermemt>();
    }
}
