using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;


    public void ChangePanel1()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(true);
    }




}
