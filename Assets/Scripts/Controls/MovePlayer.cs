using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 1;
    [SerializeField] private float playerSpeedModifier = 1;
    public float PlayerSpeedModifier { get; set; }

    private bool finished = false;

    private float moveFloat;

    private Vector2 mousePressPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3((moveFloat * playerSpeedModifier * 3) * Time.deltaTime, 0, (playerSpeed * playerSpeedModifier) * Time.deltaTime);

        if(Input.GetMouseButtonDown(0))
        {
            mousePressPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            OnPointerDown();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            OnPointerUp();
        }
    }

    void OnPointerDown()
    {
        Vector2 inputPosition = Input.mousePosition;

        //if(Application.platform == RuntimePlatform.Android)
        //{
        //    if(Touch.)
        //}

        //If moving left
        if ((inputPosition.x - mousePressPosition.x) > 0 && transform.position.x > -1.75)
        {
            float dragSpeed = (inputPosition.x - mousePressPosition.x);
            moveFloat = -0.25f - Mathf.Clamp(dragSpeed / 300f, 0, 1);
            Debug.Log("Move Left at " + moveFloat.ToString());
        }
        //If moving right
        else if ((inputPosition.x - mousePressPosition.x) < 0 && transform.position.x < 1.75)
        {
            float dragSpeed = -(inputPosition.x - mousePressPosition.x);
            moveFloat = 0.25f + Mathf.Clamp(dragSpeed / 300f, 0, 1);
            Debug.Log("Move Right at " + moveFloat.ToString());
        }
        else 
        {
            moveFloat = 0;
        }
    }

    void OnPointerUp()
    {
        moveFloat = 0;
    }
}
