using UnityEngine;

public class MovementPointer : MonoBehaviour
{
    public bool CanMoveUp;
    public bool CanMoveDown;
    public bool CanMoveLeft;
    public bool CanMoveRight;

    public GameObject LeftNode;
    public GameObject RightNode;
    public GameObject UpNode;
    public GameObject DownNode;

    public bool IsLeftWarp = false;
    public bool IsRightWarp = false;

    private void Start()
    {
        CheckDownDirection();
        CheckLeftDirection();
        CheckRightDirection();
        CheckUpDirection();
    }

    private void CheckUpDirection()
    {
        var direction = Vector2.up;
        RaycastHit2D[] raycastHits = Physics2D.RaycastAll(transform.position, direction);
        foreach(var hit in raycastHits)
        {
            float distanceY = Mathf.Abs(transform.position.y - hit.point.y);
            if(distanceY < 0.4f)
            {
                CanMoveUp = true;
                UpNode = hit.collider.gameObject;
            }
        }
    }

    private void CheckDownDirection()
    {
        var direction = Vector2.down;
        RaycastHit2D[] raycastHits = Physics2D.RaycastAll(transform.position, direction);
        foreach (var hit in raycastHits)
        {
            float distanceY = Mathf.Abs(transform.position.y - hit.point.y);
            if (distanceY < 0.4f)
            {
                CanMoveDown = true;
                DownNode = hit.collider.gameObject;
            }
        }
    }

    private void CheckLeftDirection()
    {
        var direction = Vector2.left;
        RaycastHit2D[] raycastHits = Physics2D.RaycastAll(transform.position, direction);
        foreach (var hit in raycastHits)
        {
            float distanceY = Mathf.Abs(transform.position.x - hit.point.x);
            if (distanceY < 0.4f)
            {
                CanMoveLeft = true;
                LeftNode = hit.collider.gameObject;
            }
        }
    }

    private void CheckRightDirection()
    {
        var direction = Vector2.right;
        RaycastHit2D[] raycastHits = Physics2D.RaycastAll(transform.position, direction);
        foreach (var hit in raycastHits)
        {
            float distanceY = Mathf.Abs(transform.position.x - hit.point.x);
            if (distanceY < 0.4f)
            {
                CanMoveRight = true;
                RightNode = hit.collider.gameObject;
            }
        }
    }

    public GameObject GetNodeByDirection(string direction)
    {
        if (direction == "up" && CanMoveUp)
        {
            return UpNode;
        }
        else if (direction == "down" && CanMoveDown)
        {
            return DownNode;
        }
        else if (direction == "left" && CanMoveLeft)
        {
            return LeftNode;
        }
        else if (direction == "right" && CanMoveRight)
        {
            return RightNode;
        }
        else return null;
    }
}
