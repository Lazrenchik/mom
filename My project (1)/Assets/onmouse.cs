using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onmouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("hiu");
        gameObject.GetComponent<Image>().color = Color.red;
    }
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        gameObject.GetComponent<Image>().color = Color.white;
    }
}
