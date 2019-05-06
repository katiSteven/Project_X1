using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskInterface : MonoBehaviour
{
    public GameObject tempTaskObject;
    public GameObject TaskPrefab;
    public GameObject TimeTableTaskContainer;

    private TimeTableManager timeTableManager;
    private GameManager gameManager;
    private bool hasDragEnded = false;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        timeTableManager = FindObjectOfType<TimeTableManager>();
        //disable temporary task object
        tempTaskObject.SetActive(false);
    }

    public void AddTask() {
        
        //timeTableManager.AddTask(taskInfo);
    }

    private void Update() {
        // detect collision
        if (hasDragEnded) {
            Debug.Log("task interface - inside somethingIsHit()");
            if (gameManager.SomethingIsHit())
            {
                GameObject hitObject = gameManager.GetHitObject();
                print(hitObject.name);
                Debug.Log("task interface - inside somethingIsHit()");
                hasDragEnded = false;
            }
        }
    }

    public void DragTask(TaskInfo taskInfo,GameObject childImageObject) {
        //set position
        tempTaskObject.transform.position = Input.mousePosition;

        //get temporary task components
        Text taskName = tempTaskObject.transform.GetChild(0).GetComponentInChildren<Text>();

        //Replace temporary task attributes with childImageObject attributes
        GameObject temporaryTaskImageObject = tempTaskObject.transform.GetChild(0).gameObject;
        temporaryTaskImageObject = childImageObject;
        taskName.text = taskInfo.name;

        //enable temperory task
        tempTaskObject.SetActive(true);
    }

    public void EndDrag() {
        tempTaskObject.SetActive(false);
        hasDragEnded = true;
        print("Drag ended");

        //Instantiate(TaskPrefab, TimeTableTaskContainer.transform);
    }
}
