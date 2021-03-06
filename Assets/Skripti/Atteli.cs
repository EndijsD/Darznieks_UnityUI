using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atteli : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject[] aksesuaruAtteli, cepuruAtteli, krekluAtteli, jakuAtteli, biksuAtteli, kurpjuAtteli;
    public AudioSource skanasAvots;
    public AudioClip[] skanasKoAtskanot;
    private int cip;
    public GameObject sliderH, sliderV;
    float saglabatH = 1, saglabatV = 1;

    public void dropdown(int skaitlis)
    {
        if(skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            cip = 0;
        } 
        else if(skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
            cip = 1;
        }
        else if (skaitlis == 2)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
            cip = 2;
        }
    }

    public void atskanot()
    {
        if(cip == 0)
            skanasAvots.PlayOneShot(skanasKoAtskanot[0]);
        else if(cip == 1)
            skanasAvots.PlayOneShot(skanasKoAtskanot[1]);
        else if(cip == 2)
            skanasAvots.PlayOneShot(skanasKoAtskanot[2]);
    }

    public void beigtAtskanot()
    {
        skanasAvots.Stop();
    }

    public void mainitLielumuHorizontali()
    {
        float pasreizejaVertiba = sliderH.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, saglabatV);
        saglabatH = 1F * pasreizejaVertiba;
    }

    public void mainitLielumuVertikali()
    {
        float pasreizejaVertiba = sliderV.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(saglabatH, 1F * pasreizejaVertiba);
        saglabatV = 1F * pasreizejaVertiba;
    }

    public void paraditPirmoA(bool vertiba)
    {
        aksesuaruAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroA(bool vertiba)
    {
        aksesuaruAtteli[1].SetActive(vertiba);
    }
    public void paraditTresoA(bool vertiba)
    {
        aksesuaruAtteli[2].SetActive(vertiba);
    }


    public void paraditPirmoC(bool vertiba)
    {
        cepuruAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroC(bool vertiba)
    {
        cepuruAtteli[1].SetActive(vertiba);
    }
    public void paraditTresoC(bool vertiba)
    {
        cepuruAtteli[2].SetActive(vertiba);
    }


    public void paraditPirmoKreklu(bool vertiba)
    {
        krekluAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroKreklu(bool vertiba)
    {
        krekluAtteli[1].SetActive(vertiba);
    }


    public void paraditPirmoJ(bool vertiba)
    {
        jakuAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroJ(bool vertiba)
    {
        jakuAtteli[1].SetActive(vertiba);
    }
    public void paraditTresoJ(bool vertiba)
    {
        jakuAtteli[2].SetActive(vertiba);
    }


    public void paraditPirmoB(bool vertiba)
    {
        biksuAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroB(bool vertiba)
    {
        biksuAtteli[1].SetActive(vertiba);
    }
    public void paraditTresoB(bool vertiba)
    {
        biksuAtteli[2].SetActive(vertiba);
    }


    public void paraditPirmoK(bool vertiba)
    {
        kurpjuAtteli[0].SetActive(vertiba);
    }
    public void paraditOtroK(bool vertiba)
    {
        kurpjuAtteli[1].SetActive(vertiba);
    }
    public void paraditTresoK(bool vertiba)
    {
        kurpjuAtteli[2].SetActive(vertiba);
    }
}
