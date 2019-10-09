﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchQueryStore : MonoBehaviour
{
    public List<GameObject> fetchObjs;
    public List<GameObject> predators;
    // Start is called before the first frame update
    void Start()
    {
        fetchObjs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            if (!fetchObjs.Contains(other.gameObject))
            {
                fetchObjs.Add(other.gameObject);
            }


        }
        else if (other.gameObject.CompareTag("Animal"))
        {
            if (other.gameObject.GetComponent<AnimalBase>().animalType == AnimalType.Predator)
            {
                if (!fetchObjs.Contains(other.gameObject))
                {
                    predators.Add(other.gameObject);
                }
            }


        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            fetchObjs.Remove(other.gameObject);

        }
        else if (other.gameObject.CompareTag("Animal"))
        {
            if (other.gameObject.GetComponent<AnimalBase>().animalType == AnimalType.Predator)
            {
                predators.Remove(other.gameObject);
            }


        }

    }
}
