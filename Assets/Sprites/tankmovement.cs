using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour
{
    public float speed = 7;
    public float angularspeed = 3;
    private Rigidbody rigidbody0;
    public float number = 1;            //增加一个玩家的编号
    public AudioClip stop;
    public AudioClip move;
    private AudioSource audio1;
    private float slowtimeval = 0;
    private float faaa;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody0 = this.GetComponent<Rigidbody>();
        audio1 = this.GetComponent<AudioSource>();
        faaa = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(slowtimeval>0)
        {
            speed = 4;
            angularspeed = 2;
            slowtimeval -= Time.deltaTime;
        }
        else
        {
            speed = faaa;
            angularspeed = 3;
        }
    }
    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical_player" + number);
        rigidbody0.velocity = transform.forward * v * speed;
        float h = Input.GetAxis("Horizontal_player" + number);
        rigidbody0.angularVelocity = transform.up * h * angularspeed;
        if(Mathf.Abs(h)>0.1||Mathf.Abs(v)>0.1)
        {
            audio1.clip = move;
            if(audio1.isPlaying==false)
            audio1.Play();
        }
        else
        {
            audio1.clip = stop;
            if(audio1.isPlaying==false)
            audio1.Play();
        }
    }
    void slow()
    {
        slowtimeval = 2;
    }
}
