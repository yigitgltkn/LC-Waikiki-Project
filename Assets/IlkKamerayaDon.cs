using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlkKamerayaDon : MonoBehaviour
{
    public GameObject canvasToActivate;
    public Camera mainCamera; // Birinci kamera
    public Camera secondCamera; // İkinci kamera
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCamera()
    {
        // Butona tıklandığında kamera değişimi yapalım.
        canvasToActivate.SetActive(true);
        mainCamera.enabled = !mainCamera.enabled;
        secondCamera.enabled = !secondCamera.enabled;
    }
}
