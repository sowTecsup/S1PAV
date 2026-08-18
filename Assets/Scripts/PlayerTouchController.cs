using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;


public class PlayerTouchController : MonoBehaviour
{
    public float speed = 5f;

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }

    private void Update()
    {
        foreach (var touch in UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches)
        {
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                Vector3 targetPosition = Camera.main.ScreenToWorldPoint(touch.screenPosition);
                targetPosition.z = 0f;

                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
        }
    }
}
