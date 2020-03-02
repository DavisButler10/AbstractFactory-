using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public AKSpawner m_SpawnerAK;
    IAK currentRifle;

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            m_SpawnerAK.SpawnBasicAK();
            //IAK rifle = new BasicAK();
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());

        }

        if (Input.GetKeyDown("q"))
        {
            m_SpawnerAK.SpawnAKwReflexSight();
            //IAK rifle = new BasicAK();
            //rifle = new WithReflexSight(rifle);
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("w"))
        {
            m_SpawnerAK.SpawnAKwStock();
            //IAK rifle = new BasicAK();
            //rifle = new WithStock(rifle);
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("e"))
        {
            m_SpawnerAK.SpawnAKwRGrip();
            //IAK rifle = new BasicAK();
            //rifle = new WithGrip(rifle);
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("r"))
        {
            m_SpawnerAK.SpawnAKwRSilencer();
            //IAK rifle = new BasicAK();
            //rifle = new WithSilencer(rifle);
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("t"))
        {
            m_SpawnerAK.SpawnAKwDrum();
            //IAK rifle = new BasicAK();
            //rifle = new WithDrum(rifle);
            //currentRifle = rifle;
            //Debug.Log("Accuracy: " + rifle.GetAccuracy());
            //Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("d"))
        {
            if (currentRifle != null)
            {
                GameObject.Destroy(currentRifle.GetGameObject());
                currentRifle = null;
            }
        }

        if (Input.GetKeyDown("a"))
        {
            GameObject[] array = GameObject.FindGameObjectsWithTag("AK");
            foreach(GameObject i in array)
            {
                GameObject.Destroy(i);
            }
                currentRifle = null;
        }
    }
}