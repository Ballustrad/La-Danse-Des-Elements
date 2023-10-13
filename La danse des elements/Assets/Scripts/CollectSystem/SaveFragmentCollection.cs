using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFragmentCollection : MonoBehaviour
{
    private int Fragment = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Fragment")
        {
            Fragment++;
            Debug.Log(Fragment);
            Destroy(other.gameObject);
        }
    }
}
