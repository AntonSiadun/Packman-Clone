using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MovementController _movementController;

    private void Awake()
    {
        _movementController = GetComponent<MovementController>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _movementController.SetDirection("left");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _movementController.SetDirection("up");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _movementController.SetDirection("right");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _movementController.SetDirection("down");
        }
    }
}
