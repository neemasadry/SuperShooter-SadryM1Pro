﻿using UnityEngine;
using UnityEngine.UI;

public class LifeBarScript : MonoBehaviour
{
    Image image;

    public Life_Chapter16 targetLife;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        image.fillAmount = targetLife.amount / 100;
    }
}
