using UnityEngine;
using UnityEngine.UIElements;

public class hazard : MonoBehaviour
{
    public Vector2 origin;
    public Vector2 velocity;

    public Rigidbody2D myBody;
    public int distanceThreshold = 5;

    public int movingUp = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        origin = transform.position;
        movingUp = Random.Range(0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempVelocity = Vector2.zero;
        if (movingUp == 0)
        {
            tempVelocity.y = 2;
        }
        else if (movingUp == 1)
        {

            tempVelocity.y = -2;
        }    
      
        // Move down

        // if position is origin + threshold
        // switch to opposite direction
        // ex: if movingUp is 1 now it is 0

        if (transform.position.y >= origin.y + distanceThreshold)
        {
            movingUp = 1;
        }
        else if (transform.position.y <= origin.y - distanceThreshold)
        {
            movingUp = 0;
        }

        myBody.linearVelocity = tempVelocity;
    }


}
