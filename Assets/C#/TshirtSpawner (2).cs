using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TshirtSpawner : MonoBehaviour
{
    // Spawnlamak istediğimiz prefabları tutan dizi veya liste
    public GameObject[] SpawnObjects;

    // Spawnlanacak yeri belirleyen GameObject
    public GameObject SpawnPoint;

    // Son spawnlanan objeyi tutan GameObject
    private GameObject SpawnedObject;

    void Update()
    {
        // Sol mouse tuşuna basıldığında
        if (Input.GetMouseButtonDown(0))
        {
            // Mouse pozisyonundan bir ışın fırlat
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Işın bir Collider ile çarpıştıysa
            if (Physics.Raycast(ray, out hit))
            {
                // Çarpışan objeyi al
                GameObject clickedObject = hit.transform.gameObject;

                // Objeyi SpawnObjects dizisinde veya listesinde ara
                foreach (GameObject spawnObject in SpawnObjects)
                {
                    // Objeyi bulduysak
                    if (spawnObject == clickedObject)
                    {
                        // Daha önce spawnlanmış bir obje varsa yok et
                        if (SpawnedObject != null)
                        {
                            Destroy(SpawnedObject);
                        }

                        // Objeyi SpawnPoint'in konumunda ve rotasyonunda spawnla
                        SpawnedObject = Instantiate(spawnObject, SpawnPoint.transform.position, SpawnPoint.transform.rotation);

                        // Döngüden çık
                        break;
                    }
                }
            }
        }
    }
}