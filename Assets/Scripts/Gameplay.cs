using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    [SerializeField] int miningSpeed = 3;
    [SerializeField] int bronzeSupply = 3;
    [SerializeField] int silverSupply = 2;
    [SerializeField] int playerBronze;
    [SerializeField] int playerSilver;
    public GameObject Bronze;
    public GameObject Silver;
    int spawnSpot = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerBronze = 0;
        playerSilver = 0;
        InvokeRepeating("Mining", miningSpeed, miningSpeed);
    }

    void Mining()
    {
        if (bronzeSupply > 0)
            {
            bronzeSupply -= 1;
            playerBronze += 1;
            Instantiate(Bronze, new Vector3(spawnSpot, 0, 0), Quaternion.identity);
            spawnSpot += 1;
        }
        if (bronzeSupply <= 0 && silverSupply > 0)
            {
            silverSupply -= 1;
            playerSilver += 1;
            Instantiate(Silver, new Vector3(spawnSpot, 0, 0), Quaternion.identity);
            spawnSpot += 1;
        }
        DisplayPlayerSupplies();
    }

    void DisplayPlayerSupplies()
    {
        print("Player bronze: ");
        print(playerBronze);
        print("Player silver: ");
        print(playerSilver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
