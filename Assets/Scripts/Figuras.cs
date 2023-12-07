using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figuras : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;

    public Rigidbody Rigidbody
    {
        get { return rigidBody; }
        set { rigidBody = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Explotar(Vector3 pos)
    {
        rigidBody.AddExplosionForce(10, pos, 100, 10, ForceMode.Impulse);
    }
}
