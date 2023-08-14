using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;


public class PerdeAcilSC : MonoBehaviour
{
    public Animator perdeAnimator;
    private float perdeAcilmaSuresi = 20f;
    private float gecenSure = 0f;
    private bool perdeAcik = false;

    private void Start()
    {
        // Perde Animator bileşenine erişiyoruz
        perdeAnimator = GetComponent<Animator>();

        // Perdeyi kapalı başlatıyoruz
        perdeAcik = false;
        perdeAnimator.SetBool("Acil", perdeAcik);
    }

    private void Update()
    {
        // Eğer perde kapalıysa ve geçen süre 20 saniyeyi aşarsa, perdeyi açıyoruz
        if (!perdeAcik)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= perdeAcilmaSuresi)
            {
                perdeAcik = true;
                perdeAnimator.SetBool("Acil", perdeAcik);
            }
        }
    }

    // Eğer perdeyi bir düğmeye basarak açmak isterseniz bu metodunu çağırabilirsiniz
    public void PerdeyiAc()
    {
        perdeAcik = true;
        perdeAnimator.SetBool("Acik", perdeAcik);
    }
}
