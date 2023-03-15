using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newweaponse : MonoBehaviour
{
    SpriteRenderer sp;
    [SerializeField]
    Sprite[] list = new Sprite[8];
    SpriteRenderer asd;
    public static int ep;
    abc _abcScript;





    public void motiga()
    {
        if (magazin.coin >= 100)
        {
            ep = 1;
            asd.sprite = list[1];
            magazin.coin -= 100;
            _abcScript.b = 2;

            PlayerPrefs.SetInt("penis", _abcScript.b);
            PlayerPrefs.SetInt("zalupa", ep);
        }
    }
    public void molot()
    {
        if (magazin.coin >= 200)
        {
            ep = 2;
            asd.sprite = list[2];
            magazin.coin -= 200;
            _abcScript.b = 4;

            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void lineika()
    {
        if (magazin.coin >= 500)
        {
            ep = 3;
            asd.sprite = list[3];
            magazin.coin -= 500;
            _abcScript.b = 6;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void bita()
    {
        if (magazin.coin >= 1000)
        {
            ep = 4;

            asd.sprite = list[4];
            magazin.coin -= 1000;
            _abcScript.b = 8;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void zont()
    {
        if (magazin.coin >= 1500)
        {
            ep = 5;

            asd.sprite = list[5];
            magazin.coin -= 1500;
            _abcScript.b = 10;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void vetka()
    {
        if (magazin.coin >= 3000)
        {
            ep = 6;

            asd.sprite = list[6];
            magazin.coin -= 3000;
            _abcScript.b = 15;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void kirka()
    {
        if (magazin.coin >= 4500)
        {
            ep = 7;

            asd.sprite = list[7];
            magazin.coin -= 4500;
            _abcScript.b = 20;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void matan()
    {
        if (magazin.coin >= 8000)
        {
            ep = 8;

            asd.sprite = list[8];
            magazin.coin -= 8000;
            _abcScript.b = 25;
            PlayerPrefs.SetInt("penis", _abcScript.b);

            PlayerPrefs.SetInt("zalupa", ep);

        }
    }
    public void skovoroda()
    {
        ep = 0;
        asd.sprite = list[0];
        _abcScript.b = 1;

        PlayerPrefs.SetInt("zalupa", ep);
        PlayerPrefs.SetInt("penis", _abcScript.b);
    }

        // Start is called before the first frame update
        void Start()
        {
            asd = GameObject.Find("Square").GetComponent<Transform>().GetComponent<SpriteRenderer>();
            asd.sprite = list[ep];

            ep = PlayerPrefs.GetInt("zalupa");
            asd.sprite = list[ep];
            _abcScript = GameObject.Find("Goodbtn").GetComponent<abc>();
            _abcScript.b = PlayerPrefs.GetInt("penis") != 0 ? PlayerPrefs.GetInt("penis") : 1;

        }

        // Update is called once per frame
        void Update()
        {
            abc.textcoin.text = $"{magazin.coin}";
            abc.texta = GameObject.Find("Score").GetComponent<Text>();
        }

    }
