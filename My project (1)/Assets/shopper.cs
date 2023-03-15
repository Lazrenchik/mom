using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopper : MonoBehaviour
{
    public GameObject panelka;
    public void magazinforsword()
    {
        panelka.SetActive(!panelka.activeSelf);
    }
    // Start is called before the first frame update
    void Start()
    {
        panelka = GameObject.Find("Panel");
        panelka.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
