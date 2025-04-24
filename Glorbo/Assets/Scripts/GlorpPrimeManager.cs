using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlorpPrimeManager : MonoBehaviour
{
    public static GlorpPrimeManager instance;
    public int health;
    public int maxHealth;
    public GameObject glorbPrime;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void respawnGlorpPrime(Vector2 position)
    {
        glorbPrime.transform.position = position;
        glorbPrime.SetActive(true);
    }
}
