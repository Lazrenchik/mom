using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KNOPKA : MonoBehaviour
            
{
    static int a = 3;
    static int kak = 9;
    [SerializeField]
    private Sprite[] list = new Sprite[kak];
    
    [SerializeField]
    private Sprite[] lista = new Sprite[6];
    private int ai = 0;
    int q;
    [SerializeField]
    private Sprite[] listok = new Sprite[a];
    int kik = -1;


    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("SavedCash", magazin.coin);
    }







    // Start is called before the first frame update

    void Start()
    {
        magazin.coin = PlayerPrefs.GetInt("SavedCash");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.GetComponent<abc>().a <= 0) 
        {

            Debug.Log(a);
            if (ai+1 == 10)
            {
                ai = 0;
            }
            
            else
            {
                ai += 1;
            }
            if (ai == 0)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[0];
                
               
            }
            if (ai == 1)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                



            }
            if (ai == 2)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[1];
                


            }
            if (ai == 3)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                

            }
            if (ai == 4)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[2];
                

            }
            if (ai == 5)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[3];
                

            }

            if (ai == 6)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[4];
                

            }
            if (ai == 7)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                

            }
            if (ai == 8)
            {
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = list[ai];
                GameObject.Find("fon1").GetComponent<SpriteRenderer>().sprite = lista[5];
                

            }
            if (ai == 9)
            {
                
                if(kik+1 == 3)
                {
                    kik = 0;
                }
                else
                {
                    kik += 1;
                }
                
                gameObject.GetComponent<abc>().a = 50;
                magazin.coin += 10;
                GameObject.Find("Goodbtn").GetComponent<RectTransform>().GetComponent<Image>().sprite = listok[kik];
             

            }
            gameObject.GetComponent<abc>().a = 50;
            PlayerPrefs.SetInt("SavedCash", magazin.coin);
            Debug.Log(magazin.coin);
            
        }

    }
}
