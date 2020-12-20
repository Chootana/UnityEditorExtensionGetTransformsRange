using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test : MonoBehaviour
{
    [SerializeField]
    GameObject fromObject;

    [SerializeField]
    GameObject toObject;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] arm = this.gameObject.GetTransformsRange(from: fromObject.name, to: toObject.name);

        if (arm != null)
        {
            foreach (Transform joint in arm)
            {
                Debug.Log(joint.name);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
