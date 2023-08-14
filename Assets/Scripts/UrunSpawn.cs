using DG.Tweening; //DoTween assetinin kütüphanesi
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UrunSpawn : MonoBehaviour
{
    [Header("Spawnlanacak Objelerin Listesi")]
    public GameObject[] urunGO;
    [Header("Menüdeki Ürünlerin Resim Listesi")]
    public RectTransform[] urunListeGO;
    public GameObject spawnPoint;
    private GameObject geciciGO;
    private int tshirtNO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UrunuBelirle(int urunDiziNo) //Ürün listesinde tıkladığımız ürünlerin click eventi için
    {
         tshirtNO= urunDiziNo; //Menüden seçilen ürünün dizi indexini hafızada tutuyor
    }
    public void UrunSpawnla() //Spawnlama butonunun click eventi için
    {
        if (geciciGO != null) //Daha önceden spawnlanan obje varsa yok ediyor :)
        {
            Destroy(geciciGO);
        }
        geciciGO = Instantiate(urunGO[tshirtNO]); //Hafızada duran index numarasındaki objeyi geçiçi gameobject olarak tanımladığımız değişkene eşitliyor ve spawnlıyor
        geciciGO.transform.position = spawnPoint.transform.position; //Oluşturulan objenin konumunu belirlediğimiz noktaya eşitliyor
    }
    public void UrunSecimi(int urunListeDiziNo) //Ürün listesinde tıkladığımız ürünlerin click eventi için(Görselin büyüyüp,küçülmesi)
    {
        //Ürünlistesinde tıkladığımız ürünün index numarısını çekiyoruz(click eventinde numara girip buraya yolluyoruz)
        foreach (var item in urunListeGO) 
        {
            if (item == urunListeGO[urunListeDiziNo])//Gelen numaranın resim dizisindeki  hangi itemiyle eşleştiğine bakıyoruz
            {
                item.DOScale(new Vector2(1.1f, 1.1f), 0.5f);//Eşleşen itemin boyutunu büyütüyoruz.Resmin büyümesi aniden değilde daha yumuşak olması için  dotween assetinden yararlanıyoruz
            }
            else
            {
                item.DOScale(new Vector2(1, 1), 0.5f);//Eşleşmeyen diğer resimlerin boyutunu default a çekiyoruz
            }
        }
    }
}
