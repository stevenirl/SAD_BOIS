using UnityEngine;

public class PlayerPosition : MonoBehaviour
{

    //We need the position of the user as a Transform
    public Transform playerTransform; 

    //We need something to hold the position of the circle

    public float y = -5;

    // Update is called once per frame
    void Update()
    {
        //Create a vector to hold the position of the player
        Vector3 pos = new Vector3(playerTransform.position.x, y, playerTransform.position.z);

        //Apply the position of the player to the sphere
        transform.position = pos;
    }
}
