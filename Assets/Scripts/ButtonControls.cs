using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonControls : MonoBehaviour
{
    public RectTransform tshirtGrid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SagaKaydir()
    {
        tshirtGrid.DOAnchorPosX(-277f,1);
    }
    public void SolaKaydir()
    {
        tshirtGrid.DOAnchorPosX(830f, 1);
    }
}
