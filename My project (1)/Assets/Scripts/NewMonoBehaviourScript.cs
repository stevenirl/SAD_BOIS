using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // We need the position of the user as a transform
public Transform playertransform;

    // move the hieght of position below the pavilion
public float y = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
    // Update is called once per frame
    void Update()
    {
        // create a vector to hold the position of the player
Vector3 pos= new Vector3(playertransform.position.x, y, playertransform.position.z); 


        // apply the position of the player to the sphere
        transform.position = pos;
    }
}
