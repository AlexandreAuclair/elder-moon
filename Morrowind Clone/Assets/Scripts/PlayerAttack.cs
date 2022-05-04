using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator anim;
    private float fDammage;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            anim.SetBool("hit", true);
            StartCoroutine(Delai());
        }
    }

    private IEnumerator Delai()
    {
        if(Input.GetMouseButton(0)) {
            anim.SetBool("secondClick", true);
        }
        yield return new WaitForSeconds(.2f);
        anim.SetBool("hit", false);
        anim.SetBool("secondClick", false);
    }
}
