using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject[] aksesuari, cepures, krekli, jakas, bikses, kurpes;
    int i;

    public void Aksesuari(bool vertiba)
    {
        i = 0;
        while (i != 3)
        {
            aksesuari[i].SetActive(vertiba);
            i++;
        }
    }

    public void Cepures(bool vertiba)
    {
        i = 0;
        while (i != 3)
        {
            cepures[i].SetActive(vertiba);
            i++;
        }
    }

    public void Krekli(bool vertiba)
    {
        i = 0;
        while (i != 2)
        {
            krekli[i].SetActive(vertiba);
            i++;
        }
    }

    public void Jakas(bool vertiba)
    {
        i = 0;
        while (i != 3)
        {
            jakas[i].SetActive(vertiba);
            i++;
        }
    }

    public void Bikses(bool vertiba)
    {
        i = 0;
        while (i != 3)
        {
            bikses[i].SetActive(vertiba);
            i++;
        }
    }

    public void Kurpes(bool vertiba)
    {
        i = 0;
        while (i != 3)
        {
            kurpes[i].SetActive(vertiba);
            i++;
        }
    }
}
