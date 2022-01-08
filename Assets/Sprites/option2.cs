using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option2 : MonoBehaviour
{
    private int choice = 1;
    public Transform pos1;
    public Transform pos2;
    public int num;
    public bool isselect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && choice == 2&&isselect==false)
        {
            transform.position = pos1.position;
            choice = 1;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && choice == 1&&isselect==false)
        {
            transform.position = pos2.position;
            choice = 2;
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && choice == 1)
        {
            PlayerPrefs.SetFloat("num2", 1);
            isselect = true;
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) && choice == 2)
        {
            PlayerPrefs.SetFloat("num2", 2);
            isselect = true;
        }
    }
}
