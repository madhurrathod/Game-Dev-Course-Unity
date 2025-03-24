// Video Link: https://www.youtube.com/watch?v=PCQ32PB9cIU&list=PLE88AN3qf5885q17x_xs3b2KqIiRzZwqu&index=8&ab_channel=MadhurSensei
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
