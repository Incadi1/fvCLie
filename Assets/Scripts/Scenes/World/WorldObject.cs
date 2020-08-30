using UnityEngine;


public class WorldObject : MonoBehaviour
{
    public long objectId;
    public volatile CharacterDataHolder characterData;
    private double distance = 0;

    private Animator animator;
    private Rigidbody rigidBody;

    // Is grounded related.
    public volatile bool isGrounded = false;


    private void Start()
    {
        distance = WorldManager.Instance.CalculateDistance(transform.position);
        animator = GetComponent<Animator>();
        animator.applyRootMotion = true;
        rigidBody = GetComponent<Rigidbody>();
    }

    public void MoveObject(Vector3 newPosition, float heading)
    {
        if (gameObject == null || !gameObject.activeSelf)
        {
            return;
        }

        float step = Time.deltaTime * 10;
        rigidBody.MovePosition(Vector3.Lerp(transform.position, newPosition, step));

        Quaternion oldHeading = transform.localRotation;
        Quaternion newHeading = transform.localRotation;
        Vector3 curvAngle = newHeading.eulerAngles;
        curvAngle.y = heading;
        newHeading.eulerAngles = curvAngle;
        transform.localRotation = Quaternion.Lerp(oldHeading, newHeading, step);

        // Update distance value.
        distance = WorldManager.Instance.CalculateDistance(transform.position);

    }

    public void AnimateObject(float velocityX, float velocityZ,  bool isGrounded)
    {
        if (gameObject == null || !gameObject.activeSelf)
        {
            return;
        }

        this.isGrounded = isGrounded;
        
        animator.SetFloat(AnimationController.VELOCITY_Z_VALUE, velocityZ);
        animator.SetFloat(AnimationController.VELOCITY_X_VALUE, velocityX);
        
    }

    public bool IsObjectGrounded()
    {
        return isGrounded;
    }


    public double GetDistance()
    {
        return distance;
    }
}