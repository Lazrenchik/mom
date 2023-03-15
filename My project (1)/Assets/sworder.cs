using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sworder : MonoBehaviour
{
    public Animator _animator;

    public void Onclick()
    {
        _animator.SetInteger("a", 1);
        Invoke("chg", 0.2f);

    }
    void chg()
    {
        _animator.SetInteger("a", 0);
    }
    
}
