using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _renderer;

    private MovementController _movementController;

    private void Awake()
    {
        _movementController = GetComponent<MovementController>();
    }

    void Update()
    {
        _animator.SetBool("IsMoving", true);
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

        bool flipX =false, flipY = false;
        if(_movementController.LastMovingDirection == "up")
        {
            _animator.SetInteger("Direction",1);
        }
        else if (_movementController.LastMovingDirection == "down")
        {
            _animator.SetInteger("Direction", 1);
            flipY = true;
        }
        else if (_movementController.LastMovingDirection == "left")
        {
            _animator.SetInteger("Direction", 0);
        }
        else if (_movementController.LastMovingDirection == "right")
        {
            _animator.SetInteger("Direction", 0);
            flipX = true;
        }
        _renderer.flipX = flipX;
        _renderer.flipY = flipY;

    }
}
