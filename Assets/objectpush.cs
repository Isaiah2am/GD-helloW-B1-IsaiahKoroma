using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpush : MonoBehaviour
{
    [SerializeField]
    public float forceMaginute;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("oncollider");
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if (rigidbody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection*forceMaginute, transform.position, ForceMode.Impulse);
        }
    }
      
    

}
