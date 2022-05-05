using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouvrir_fermer : MonoBehaviour
{
    [SerializeField] private GameObject popup_1 ;
    [SerializeField] private GameObject popup_2 ;

    public void ouvrir()
    {
        popup_1.SetActive(true);
        popup_2.SetActive(false);

    }
}
