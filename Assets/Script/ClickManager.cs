﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    
    public Camera Left1Camera, Left2Camera, Left3Camera, Right1Camera, Right2Camera, Right3Camera, BookCamera, MainCamera, BossCamera, BeamCamera, WallCamera;
    public GameObject PhoneUI;//아영
    public static int CanvasUI;//아영
    public GameObject ClickArea;//아영 right-3

    // Start is called before the first frame update
    void Start()
    {
        
        Left1Camera.gameObject.SetActive(false);
        Left2Camera.gameObject.SetActive(false);
        Left3Camera.gameObject.SetActive(false);
        Right1Camera.gameObject.SetActive(false);
        Right2Camera.gameObject.SetActive(false);
        Right3Camera.gameObject.SetActive(false);
        BookCamera.gameObject.SetActive(false);
        BossCamera.gameObject.SetActive(false);
        BeamCamera.gameObject.SetActive(false);
        
        WallCamera.gameObject.SetActive(false);

        //아영
        CanvasUI = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if(hit.transform.gameObject.tag == "Left-1")
                {
                    Left1Camera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Left-2")
                {
                    Left2Camera.gameObject.SetActive(true);

                    Left1Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Left-3")
                {
                    Left3Camera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Right-1")
                {
                    Right1Camera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Right-2")
                {
                    Right2Camera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Right-3")
                {
                    Right3Camera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                    ClickArea.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Boss")
                {
                    BossCamera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Book")
                {
                    BookCamera.gameObject.SetActive(true);

                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    BeamCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Beam")
                {
                    BeamCamera.gameObject.SetActive(true);

                    BookCamera.gameObject.SetActive(false);
                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                    WallCamera.gameObject.SetActive(false);
                }
                if(hit.transform.gameObject.tag == "Wall")
                {
                    WallCamera.gameObject.SetActive(true);

                    BeamCamera.gameObject.SetActive(false);
                    BookCamera.gameObject.SetActive(false);
                    Left2Camera.gameObject.SetActive(false);
                    Left3Camera.gameObject.SetActive(false);
                    Left1Camera.gameObject.SetActive(false);
                    Right2Camera.gameObject.SetActive(false);
                    Right3Camera.gameObject.SetActive(false);
                    Right1Camera.gameObject.SetActive(false);
                    BossCamera.gameObject.SetActive(false);
                    MainCamera.gameObject.SetActive(false);
                }

                //아영이 넣음
                if (hit.transform.gameObject.tag == "Phone")
                {
                    Debug.Log("왜앙돼");
                    PhoneUI.SetActive(true);
                    CanvasUI = 1;
                }
            }
            
        }
    }
}
