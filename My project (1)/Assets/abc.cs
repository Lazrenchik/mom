using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abc : MonoBehaviour
{
    public int a = 50;
    

    public static Text texta;
    public static Text textcoin;
    public GameObject _sworder;
    public int b = 1;
    
    public GameObject Player;
    public Slider slider;
    
    



    public void addNum()
    {
        
        a -= b;
        Debug.Log(a);
    }
    
    





    // Start is called before the first frame update
    void Start()
    {
        
        _sworder = GameObject.Find("Sword");
        texta = GameObject.Find("Score").GetComponent<Text>();
        textcoin = GameObject.Find("Money").GetComponent<Text>();
        this.GetComponent<Button>().onClick.AddListener(_sworder.GetComponent<sworder>().Onclick);
        textcoin.text = $"{magazin.coin}";
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = a;

    }
}
