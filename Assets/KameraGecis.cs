using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraGecis : MonoBehaviour
{
    public Camera mainCamera; // Birinci kamera
    public Camera secondCamera; // İkinci kamera
    public GameObject canvasToActivate;


    private void Start()
    {
        // İlk başta sadece birinci kamera aktif olsun, ikinci kamera kapalı olsun.
        mainCamera.enabled = true;
        secondCamera.enabled = false;
    }

    public void SwitchCamera()
    {
        // Butona tıklandığında kamera değişimi yapalım.
        canvasToActivate.SetActive(false);
        mainCamera.enabled = !mainCamera.enabled;
        secondCamera.enabled = !secondCamera.enabled;
    }
}
