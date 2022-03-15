/*
 * (Luke Hensley)
 * (Assignment 5B)
 * (Controls win condition)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndBehavior : MonoBehaviour
{
    public Text winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            winText.gameObject.SetActive(true);
        }
    }
}
