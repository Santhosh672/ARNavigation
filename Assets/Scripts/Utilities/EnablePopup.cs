using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePopup : MonoBehaviour
{
    [SerializeField] GameObject popup;

    string target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTarget(string targetName)
    {
        target = targetName;
        Debug.Log("Target : " + targetName);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == target)
        {
            Debug.Log("Reached Destination!");
            popup.SetActive(true);
        }
    }

}
