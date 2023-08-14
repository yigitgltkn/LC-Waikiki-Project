using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAcKapa : MonoBehaviour
{
    public GameObject canvasToActivate;
    public float delayInSeconds;

    private void Start()
    {
        // İstenilen süre sonra ActivateCanvas metodu çağrılacak
        canvasToActivate.SetActive(false);
        Invoke("ActivateCanvas", delayInSeconds);
    }

    private void ActivateCanvas()
    {
        // Canvas'i aktifleştir
        canvasToActivate.SetActive(true);
    }
}
