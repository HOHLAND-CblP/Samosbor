using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputController : MonoBehaviour
{
    public static InputController Instance;

    
    private float horizontalMove;
    private float verticalMove;
    public float HorizontalMove => horizontalMove;
    public float VerticalMove => verticalMove;

    public Vector3 MousePosition => Input.mousePosition;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }
        Instance = this;
    }

    void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
}

public enum InputType { KeyboardMouse, GamePad }