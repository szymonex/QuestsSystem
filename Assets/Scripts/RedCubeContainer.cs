using UnityEngine;

public class RedCubeContainer : MonoBehaviour
{
    public void CheckChildsCount()
    {
        if (transform.childCount - 1  == 0)
        {
            Destroy(gameObject);
        }
    }
}
