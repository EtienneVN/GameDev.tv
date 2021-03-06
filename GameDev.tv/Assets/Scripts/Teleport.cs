using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;

    void Start() 
    {
        // CHALLENGE TIP: Make sure all relevant lights are turned off until you need them on
        // because, you know, that would look cool.
        areaLight.enabled = false;
        mainWorldLight.enabled = false;
    }

    void OnTriggerEnter(Collider other) 
    {
        // Challenge 2: TeleportPlayer();
        TeleportPlayer();
        // Challenge 3: DeactivateObject();
        DeactivateObject();
        // Challenge 4: IlluminateArea();
        IlluminateArea();
        // Challenge 5: StartCoroutine ("BlinkWorldLight");
        // Challenge 6: TeleportPlayerRandom();
    }

    void TeleportPlayer()
    {
        // code goes here
        player.transform.position = teleportTarget.position;
    }

    void DeactivateObject()
    {
       // code goes here 
       GetComponent<BoxCollider>().enabled = false;
    }

    void IlluminateArea()
    {
       // code goes here 
       areaLight.enabled = true;
    }

    // IEnumerator BlinkWorldLight()
    // {
            // code goes here
    // }

    void TeleportPlayerRandom()
    {
        // code goes here... or you could modify one of your other methods to do the job.
    }

}
