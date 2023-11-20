using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getInput : MonoBehaviour
{
    private string input;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getInputText(string input)
    {
        this.input = input;
        if (input == "Ôç°²")
        {
            animator.SetTrigger("Good_Morning");
        }

    }
}
