using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CharacterPrefab;
    void Start()
    {
        GameObject character=null;
            
        if (character == null)
        {
            Instantiate(CharacterPrefab, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
