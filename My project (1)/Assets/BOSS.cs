using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public static GameObject BOSS1;
    
    // Start is called before the first frame update
    void Start()
    {
        BOSS1 = GameObject.Find("bossbtn");
        BOSS1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
