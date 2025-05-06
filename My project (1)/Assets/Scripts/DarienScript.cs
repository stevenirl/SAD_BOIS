using UnityEngine;

public class DarienScript : MonoBehaviour
{

    // we need the position of the user as a transform
    public Transform playerTransform; // the transform of the player 

    //we need something to hold the position of the circle

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // move the height position below the pavilion 
    public float y = 0;

    // Update is called once per frame
    void Update()
    {
        // create a vector to hold the position of the player 

        Vector3 pos = new Vector3(playerTransform.position.x, y, playerTransform.position.z);

        // apply the poisiiton of the player to the sphere
        transform.position = pos;
    }
}
