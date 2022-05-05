using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouvrire : MonoBehaviour
{
    [SerializeField] private GameObject popup ;

    public void ouvrir()
    {
        popup.SetActive(true);
    }
}
