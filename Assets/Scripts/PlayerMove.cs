using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private float xMax = 20.0f;
    [SerializeField] private float yMax = 20.0f;
    private Vector2 touchPosition;

    void Update()
    {
        if (Input.touchCount > 0)
        {
           
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Vector3 delta = touch.position - touchPosition;
                float xMove = delta.x / Screen.width * xMax;
                float yMove = delta.y / Screen.height * yMax;
                transform.position += new Vector3(xMove, yMove, 0);
            }
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveHorizontal, moveVertical, 0) * _speed * Time.deltaTime;
    }
}
