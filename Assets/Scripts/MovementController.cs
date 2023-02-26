using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject CurrentNode;
    public float speed = 4f;

    private string _lastMovingDirection = "";
    private string _direction = "";


    private void Update()
    {
        MovementPointer pointer = CurrentNode.GetComponent<MovementPointer>();

        transform.position = Vector2.MoveTowards(transform.position,
            CurrentNode.transform.position,
            speed * Time.deltaTime);

        if(transform.position.x == CurrentNode.transform.position.x &&
            transform.position.y == CurrentNode.transform.position.y)
        {
            var newNode = pointer.GetNodeByDirection(_direction);
            if(newNode != null)
            {
                CurrentNode = newNode;
                _lastMovingDirection = _direction;
            }
            else
            {
                _direction = _lastMovingDirection;
                newNode = pointer.GetNodeByDirection(_direction);
                if (newNode != null)
                    CurrentNode = newNode;
            }
        }
    }

    public void SetDirection(string newDirection)
    {
        _direction = newDirection;
    }

}
