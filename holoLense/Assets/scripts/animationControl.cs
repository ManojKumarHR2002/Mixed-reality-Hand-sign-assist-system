using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] string sign;

    // Start is called before the first frame update
    void Start()
    {
        sign = "idle";
        //animator = GetComponent<Animator>();
    }

    public void playAnimation()
    {
        animator.Play(sign);
    }

    public void setSign(GameObject sgn)
    {
        sign = sgn.name;
    }
}
