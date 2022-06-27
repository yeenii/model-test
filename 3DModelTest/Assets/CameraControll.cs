using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControll : MonoBehaviour
{
    public GameObject stage;

    //Rotate
    private float xRotateMove, yRotateMove;

    public float rotateSpeed = 500.0f;

    // Orthographic Zoom In, Zoom Out 
    public float maxDist = 50.0f;
    public float minDist = 5.0f;
    public float zoomSpeed = 1.0f;
    public float distance;

    //마우스 상하좌우 컨트롤 스피드 
    public float speed = 5.0f;


    void Start()
    {
        distance = Camera.main.GetComponent<Camera>().orthographicSize;
    }

    void Update()
    {
        //Rotate
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButton(0))
            {
                xRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

                Vector3 stagePosition = stage.transform.position;

                transform.RotateAround(stagePosition, Vector3.up, xRotateMove);

                transform.LookAt(stagePosition);
            }
        }


    }


    void LateUpdate()
    {
        // 휠마우스 (PC에서만 작동) 줌인 줌아웃
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && distance < maxDist)
        {
            distance += zoomSpeed;
            Camera.main.GetComponent<Camera>().orthographicSize = distance;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && distance > minDist)
        {
            distance -= zoomSpeed;
            Camera.main.GetComponent<Camera>().orthographicSize = distance;
        }

        // 마우스 X,Y 이동
        if (Input.GetMouseButton(1))
        {
            //float t_posX = Input.GetAxis("Mouse X") * speed;
            float t_posY = Input.GetAxis("Mouse Y") * speed;

            transform.position += new Vector3(0, t_posY, 0);
        }
    }

}