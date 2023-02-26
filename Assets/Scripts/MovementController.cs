using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject CurrentNode;
    public float speed = 4f;
    public string LastMovingDirection = "";
    public string Direction = "";
    public bool canWarp = true;
    public WarpController _warpController;

    private void Update()
    {
        MovementPointer pointer = CurrentNode.GetComponent<MovementPointer>();

        transform.position = Vector2.MoveTowards(transform.position,
            CurrentNode.transform.position,
            speed * Time.deltaTime);

        if(transform.position.x == CurrentNode.transform.position.x &&
            transform.position.y == CurrentNode.transform.position.y)
        {

            if(pointer.IsLeftWarp && canWarp)
            {
                CurrentNode = _warpController.RightWArp;
                Direction = LastMovingDirection = "left";
                transform.position = CurrentNode.transform.position;
                canWarp = false;
            }
            else if(pointer.IsRightWarp && canWarp)
            {
                CurrentNode = _warpController.LeftWarp;
                Direction = LastMovingDirection = "right";
                transform.position = CurrentNode.transform.position;
                canWarp = false;
            }
            else
            {
                var newNode = pointer.GetNodeByDirection(Direction);
                if (newNode != null)
                {
                    CurrentNode = newNode;
                    LastMovingDirection = Direction;
                }
                else
                {
                    Direction = LastMovingDirection;
                    newNode = pointer.GetNodeByDirection(Direction);
                    if (newNode != null)
                        CurrentNode = newNode;
                }
            }        
        }
        else
        {
            canWarp = true;
        }
    }

    public void SetDirection(string newDirection)
    {
        Direction = newDirection;
    }

}
