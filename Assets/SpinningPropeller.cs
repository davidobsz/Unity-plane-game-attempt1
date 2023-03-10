using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPropeller : MonoBehaviour
{
    public float propellerSpeed = 30f;
    public bool engineOn = false;
    public float maxmimum = 30;
    public float count = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            engineOn = true;
        } 
        if (engineOn) 
        {

            transform.Rotate(10f, 0f, 0f, Space.Self);


            StartCoroutine(WaitAndPerformAction1());




            IEnumerator WaitAndPerformAction1()
            {
                yield return new WaitForSeconds(3f);
                // Perform action 1 here
                transform.Rotate(1f, 0f, 0f, Space.Self);
                StartCoroutine(WaitAndPerformAction2());
            }

            IEnumerator WaitAndPerformAction2()
            {
                yield return new WaitForSeconds(3f);
                // Perform action 2 here
                transform.Rotate(5f, 0f, 0f, Space.Self);
                StartCoroutine(WaitAndPerformAction3());
            }

            IEnumerator WaitAndPerformAction3()
            {
                yield return new WaitForSeconds(3f);
                transform.Rotate(30f, 0f, 0f, Space.Self);
                // Perform action 3 here
            }

        }
        if (Input.GetKeyDown(KeyCode.F))
        {

            engineOn = false;
            count = 0;
            transform.Rotate(0f, 0f, 0f, Space.Self);
        }



        
        
    }
}
