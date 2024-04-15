using UnityEngine;

public class ShowHideUIOnCollision : MonoBehaviour
{
    public GameObject UI; // Reference to the UI game object
    public GameObject mainCamera; // Reference to the main camera object

    private void Update()
    {
        if (IsCameraInsideCollider())
        {
            UI.SetActive(true); // Show the UI game object
        }
        else
        {
            UI.SetActive(false); // Hide the UI game object
        }
    }

    private bool IsCameraInsideCollider()
    {
        Collider collider = GetComponent<Collider>();
        if (collider != null && mainCamera != null)
        {
            return collider.bounds.Contains(mainCamera.transform.position);
        }
        return false;
    }
}



