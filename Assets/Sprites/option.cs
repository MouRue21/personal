using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    private int choice = 1;
    public Transform pos1;
    public Transform pos2;
    public int num;
    private bool isselect=false;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)&&choice==2&&isselect==false)
        {
            transform.position = pos1.position;
            choice = 1;
        }
        else if(Input.GetKeyDown(KeyCode.S)&&choice==1&&isselect==false)
        {
            transform.position = pos2.position;
            choice = 2;
        }
        if (Input.GetKeyDown(KeyCode.Space) && choice == 1)
        {
            PlayerPrefs.SetFloat("num1", 1);
            isselect = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && choice == 2)
        {
            PlayerPrefs.SetFloat("num1", 2);
            isselect = true;
        }
        if(isselect&&player2.GetComponent<option2>().isselect)
        {
            SceneManager.LoadScene(1);
        }
    }
}
