using UnityEngine;

//makes lights HUGE on collider trigger
public class LightSensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        transform.localScale = new Vector3(3f, 3f, 3f);
    }
}
