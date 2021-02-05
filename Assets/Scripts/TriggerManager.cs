using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public GameController controller;

    public Animator keyGate;
    public Animator finalGate;

    public AudioClip coinClip;
    public AudioClip keyClip;
    public AudioClip winClip;

    public void Start()
    {
        finalGate.enabled = false;
        keyGate.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            controller.UpdateCoin();
            this.GetComponent<AudioSource>().PlayOneShot(coinClip,0.4f);
            other.gameObject.SetActive(false);

        }
        if (other.tag == "Flag")
        {
            controller.GameOver();
            other.GetComponent<AudioSource>().PlayOneShot(winClip,0.4f);
        }
        if (other.tag == "Key")
        {
            controller.hasKey = true;
            this.GetComponent<AudioSource>().PlayOneShot(keyClip,0.4f);
            other.gameObject.SetActive(false);

        }
        if (other.tag == "KeyDoorTrigger")
        {
            if (controller.coins == 4)
            {
                keyGate.enabled = true;
            }
        }
        if (other.tag == "FinalDoorTrigger")
        {
            if (controller.hasKey == true)
            {
                finalGate.enabled = true;
            }
        }
    }
}
