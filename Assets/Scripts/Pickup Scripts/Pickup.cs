using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public abstract string GetPickupMessage();

    public abstract void applyEffect(GameObject player);

    public GameObject getParent()
    {
        return gameObject;
    }
}
