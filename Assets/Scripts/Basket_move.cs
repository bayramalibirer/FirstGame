using UnityEngine;

public class Basket_move : MonoBehaviour
{
    public float speed = 10.0f;
    public float leftAndRightEdge = 10.0f;


    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * xAxis * speed * Time.deltaTime);

        Vector3 pos = transform.position;

        if (pos.x < -leftAndRightEdge)
        {
            transform.position = new Vector3(-leftAndRightEdge, pos.y, pos.z);
        }
        else if (pos.x > leftAndRightEdge)
        {
            transform.position = new Vector3(leftAndRightEdge, pos.y, pos.z);
        }
    }

}
