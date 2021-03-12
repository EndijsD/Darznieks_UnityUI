using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teksts : MonoBehaviour
{
    string vards, vecums;
    public GameObject ievadesLauksVards, ievadesLauksVecums, kurAtteloTekstu;

    public void attelotTekstu()
    {
        vards = ievadesLauksVards.GetComponent<Text>().text;
        vecums = ievadesLauksVecums.GetComponent<Text>().text;
        
        if(vards != "" && vecums != "")
        kurAtteloTekstu.GetComponent<Text>().text = vards + " ir " + vecums + " gadus vecs!";
    }
}
