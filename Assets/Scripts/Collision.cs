using UnityEngine;

public class Collision : MonoBehaviour
{
    public player movement;
    

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
