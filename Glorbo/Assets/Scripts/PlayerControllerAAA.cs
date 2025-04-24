using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerAAA : MonoBehaviour
{
    public Player player;
    private Character target;
    private Enemy hostToSwapTo;
    private static bool controlingHost = false;

    // Start is called before the first frame update
    void Start()
    {
        target = player;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Input.GetButtonDown("Jump"))
            {
                target.Jump();
            }
            if (Input.GetButtonDown("Interact"))
            {
                if(hostToSwapTo != null)
                {
                    swapToHost();
                    controlingHost = true;
                }
                else if(hostToSwapTo == null && controlingHost)
                {
                    GlorpPrimeManager.instance.respawnGlorpPrime(transform.position);
                    controlingHost = false;
                    gameObject.SetActive(false);
                }
            }
            target.Move(Input.GetAxisRaw("Horizontal"));
        }
    }

    public void swapToHost()
    {
        if(hostToSwapTo != null)
        {
            hostToSwapTo.playerTakeControl();
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            hostToSwapTo = other.GetComponent<Enemy>();
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            hostToSwapTo = null;
        }
    }

}
