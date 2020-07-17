using UnityEngine;

public class Player : MonoBehaviour
{
    private const int OneUnit = 1;

    [SerializeField] Inventar inventar;

    private float moveSpeed = 5f;

    private Vector3 targetVector;
    private Vector3 goToVector;

    private bool isRight = false;
    private bool isLeft = false;
    private bool isDown = false;
    private bool isUp = false;

    void Start()
    {
        targetVector = transform.position;
        goToVector = targetVector;
    }

    void Update()
    {
        SetDestination();
        PerformMovement();
    }

    private void SetDestination()
    {
        goToVector = Vector3.MoveTowards(goToVector, targetVector, moveSpeed * Time.deltaTime);
        transform.position = goToVector;
    }

    private void PerformMovement()
    {
        if (isUp)
        {
            targetVector.y = transform.position.y + OneUnit;
            isUp = false;
        }

        if (isDown)
        {
            targetVector.y = transform.position.y - OneUnit;
            isDown = false;
        }

        if (isRight)
        {
            targetVector.x = transform.position.x + OneUnit;
            isRight = false;
        }

        if (isLeft)
        {
            targetVector.x = transform.position.x - OneUnit;
            isLeft = false;
        }
    }

    public void MoveRight() { isRight = true; }

    public void MoveLeft() { isLeft = true; }

    public void MoveUp() { isUp = true; }

    public void MoveDown() { isDown = true; }

}
