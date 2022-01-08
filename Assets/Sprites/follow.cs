using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    private Vector3 offset;
    private Camera camera1;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = this.GetComponent<Camera>(); 
        offset = transform.position - (player1.position + player2.position) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == null || player2 == null)
            return;
        transform.position = (player2.position + player1.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);
        float size = distance * 1f;
        camera1.orthographicSize = size;
    }
}
