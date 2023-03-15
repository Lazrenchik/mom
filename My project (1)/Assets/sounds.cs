using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sounds : MonoBehaviour
{
    public AudioClip din;
    [SerializeField]
    AudioSource audio;
    
    public void music()
    {
        audio.PlayOneShot(din);

    }


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

       /* if (newweaponse.ep == 0)
        {

        }
        if (newweaponse.ep == 1)
        {

        }
        if (newweaponse.ep == 2)
        {

        }
        if(newweaponse.ep == 3)
        {

        }
        if (newweaponse.ep == 4)
        {

        }
        if (newweaponse.ep == 5)
        {

        }
        if (newweaponse.ep == 6)
        {

        }
        if (newweaponse.ep == 7)
        {

        }
        if (newweaponse.ep == 8)
        {

        }*/

    }
}
