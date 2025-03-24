using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float speedToFollow = 0.2f;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset , speedToFollow * Time.deltaTime);
    
    // transform.Translate(new Vector3(3,0,0)*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.V))
        {
            offset.z -= 15;
        }
        if(Input.GetKeyUp(KeyCode.V))
        {
            offset.z += 15;
        }
        transform.LookAt(player.transform);
    }
}
