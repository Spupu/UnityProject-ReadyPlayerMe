using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=10f;
    public float vertInput;
    public float horiInput;
    private Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity =  Mathf.Abs(speed * vertInput);
        vertInput = Input.GetAxis("Vertical");
        horiInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horiInput);
        animator.SetFloat("Speed", velocity);

        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetBool("Move", true);
        }
        else{
            animator.SetBool("Move", false);
        }
    }
}
