using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;
    [SerializeField] private bool isExitDoor; // New variable to mark this door as an exit to the next level

    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Check if this door should load the next level
            if (isExitDoor)
            {
                LevelManager.instance.NextLevel();
            }
            else
            {
                // If the player is on the left side, move to the next room
                if (collision.transform.position.x < transform.position.x)
                {
                    cam.MoveToNewRoom(nextRoom);
                    nextRoom.GetComponent<Room>().ActivateRoom(true);
                    previousRoom.GetComponent<Room>().ActivateRoom(false);
                }
                // If the player is on the right side, move to the previous room
                else
                {
                    cam.MoveToNewRoom(previousRoom);
                    previousRoom.GetComponent<Room>().ActivateRoom(true);
                    nextRoom.GetComponent<Room>().ActivateRoom(false);
                }
            }
        }
    }
}
