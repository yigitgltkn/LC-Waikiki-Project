using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float movementSpeed = 5f; // Kamera hareket hızı
    public float rotationSpeed = 3f; // Kamera dönüş hızı
    private bool freeLookEnabled = false;
    private Vector3 desiredPosition; // Animasyon oynarken hedef pozisyon
    private Quaternion desiredRotation; // Animasyon oynarken hedef rotasyon

    void Start()
    {
        // Animasyonunuzu burada başlatın
    }

    void Update()
    {
        if (!freeLookEnabled)
        {
            // Animasyonunuzun oynatma durumuyla serbest dolaşma için geçişi kontrol edin
            if (!GetComponent<Animation>().isPlaying)
            {
                freeLookEnabled = true;
            }
            else
            {
                // Animasyon oynarken kameranın hareketini durdurmak için gerekli işlemleri yapabilirsiniz.
                // Örneğin, aşağıdaki kod ile kameranın pozisyonunu sabitleyebilirsiniz.
                // desiredPosition = transform.position;
                // desiredRotation = transform.rotation;
                return;
            }
        }

        // Serbest dolaşma için gerekli kamera kontrollerini ekleyin
        // Sağ tık tuşuna basılı mı kontrolü
        if (Input.GetMouseButton(1))
        {
            // Kameranın yatay dönüşü
            float horizontalRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            transform.Rotate(0f, horizontalRotation, 0f, Space.World);

            // Kameranın dikey dönüşü
            float verticalRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.Rotate(-verticalRotation, 0f, 0f, Space.Self);
        }

        // Dikey ve yatay hareket
        float moveHorizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(moveHorizontal, 0f, moveVertical);
    }
}
