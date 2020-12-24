﻿using System.Collections;
using System.Collections.Generic;
using Lean.Gui;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class OverlayMenuUI : MonoBehaviour
{
    public GameObject cogWheelCanvas;
    public GameObject menuCanvas;
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject settingsTab;
    public GameObject calibrationButton;
    public GameObject validationButton;
    public GameObject pauseButton;
    public GameObject resumeButton;
    public GameObject endExpButton;
    public GameObject calSub1;
    public GameObject calSub2;
    public GameObject valSub1;
    public GameObject valSub2;
    public TMP_InputField subIdText1;
    public TMP_InputField subIdText2;
    public string subId1;
    public string subId2;
    public bool subId1done = false;
    public bool subId2done = false;
    public bool captureData = false;
    public bool paused = false;
    private bool settingPressed = false;
    private bool calPressed = false;
    private bool valPressed = false;
    private bool makeInteractable = true;
    private Color ogButtonColor = new Color (0.03137255f, 0.5803922f, 0.9686275f, 1f);
    private Color lessSatButtonColor = new Color (0.03137255f, 0.5803922f, 0.9686275f, 0.3f);
    private Color ogTextColor = new Color (1f,1f,1f,1f);
    private Color lessSatTextColor = new Color (1f,1f,1f,0.3f);
    
    
    // Start is called before the first frame update
    void Start()
    {
        cogWheelCanvas.SetActive((true)); 
        menuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Functions
    // Open the settings menu
    public void CogWheelButton()
    {
        // On press:
        // activate Menu
        menuCanvas.SetActive(!menuCanvas.activeSelf);
        // Deactivate sub menus in case they were opened before
        calSub1.SetActive(false);
        calSub2.SetActive(false);
        valSub1.SetActive(false);
        valSub2.SetActive(false);
        settingsTab.SetActive((false));
        settingPressed = false;
        calPressed = false;
        valPressed = false;
        // Activate pause or resume button
        if (paused)
        {
            pauseButton.SetActive(false);
            resumeButton.SetActive(true);

            // color
            startButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;

            makeInteractable = false;
            // deactivate the buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
        }
        else
        {
            pauseButton.SetActive(true);
            resumeButton.SetActive(false);
            // Reset the colors if they have been set before
            startButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            pauseButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            resumeButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;

            makeInteractable = true;
            // reactivate the buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
        }
    }

    public void StartExperiment()
    {
        // Start Experiment Scene Switch
    }

    // Settings Button
    public void SettingsButton()
    {
         if (settingPressed) 
         {
             // Setting the button color
             startButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             calibrationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             validationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             pauseButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             resumeButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             endExpButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
             endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
             
             makeInteractable = true;
             // reactivate the other buttons
             startButton.GetComponent<LeanButton>().interactable = makeInteractable;
             calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
             validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
             pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
             resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
             endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
             
            settingPressed = false;
            settingsTab.SetActive(false);
            settingsTab.SetActive(false);
         }
         else 
         {
             // Setting the button color
             startButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             calibrationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             validationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             pauseButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             resumeButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             endExpButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
             endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
             
             makeInteractable = false;
             // reactivate the other buttons
             startButton.GetComponent<LeanButton>().interactable = makeInteractable;
             calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
             validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
             pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
             resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
             endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingPressed = true;
            settingsTab.SetActive(true);
            settingsTab.SetActive(true);
         }
    }
    
    public void DataCaptureEnable()
    {
        captureData = true;
    }
    public void DataCaptureDisable()
    {
        captureData = false;
    }
    
    public void SubId1()
    {
        subId1 = subIdText1.text;
        if (!Input.GetKeyDown(KeyCode.Return) || subId1done !=false) return;
        subId1done = true;
    }
    public void SubId2()
    {
        subId2 = subIdText2.text;
        if (!Input.GetKeyDown(KeyCode.Return) || subId2done !=false) return;
        subId2done = true;
    }

    
    // Calibration button
    public void CalibrationButton()
    {
        if (calPressed)
        {
            // Setting the button color
            startButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            pauseButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            resumeButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            
            makeInteractable = true;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
            resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calPressed = false;
            calSub1.SetActive(false);
            calSub2.SetActive(false);
        }
        else
        {
            // Setting the button color
            startButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            pauseButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            resumeButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            
            makeInteractable = false;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
            resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calPressed = true;
            calSub1.SetActive(true);
            calSub2.SetActive(true);
        }
    }
    // Validation button
    public void ValidationButton()
    {
        if (valPressed)
        {
            // change the color to OG
            startButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            pauseButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            resumeButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            
            makeInteractable = true;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
            resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
            valPressed = false;
            valSub1.SetActive(false);
            valSub2.SetActive(false);
        }
        else
        {
            // Setting the button color
            startButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            pauseButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            pauseButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            resumeButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            resumeButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            
            makeInteractable = false;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            pauseButton.GetComponent<LeanButton>().interactable = makeInteractable;
            resumeButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
            valPressed = true;
            valSub1.SetActive(true);
            valSub2.SetActive(true);
        }
    }

    public void CalibrationSub1()
    {
        // Start calibration sub1
    }
    public void CalibrationSub2()
    {
        // Start calibration sub2
    }
    public void ValidationSub1()
    {
        // Start validation sub1
    }
    public void ValidationSub2()
    {
        // Start validation sub2
    }

    // Pausing or resuming the experiment (what about data capture pause?)
    public void PauseExperiment()
    {
        if (paused)
        {
            resumeButton.SetActive(false);
            pauseButton.SetActive(true);
            paused = false;
            Time.timeScale = 1;
            // color
            startButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = ogButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = ogTextColor;
            
            makeInteractable = true;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
        }
        else
        {
            pauseButton.SetActive(false);
            resumeButton.SetActive(true);
            paused = true;
            Time.timeScale = 0;
            // color
            startButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            startButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            settingsButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            settingsButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            calibrationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            calibrationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            validationButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            validationButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            endExpButton.transform.Find("Cap").GetComponent<Image>().color = lessSatButtonColor;
            endExpButton.transform.Find("Cap").Find("Text").GetComponent<Text>().color = lessSatTextColor;
            
            makeInteractable = false;
            // reactivate the other buttons
            startButton.GetComponent<LeanButton>().interactable = makeInteractable;
            settingsButton.GetComponent<LeanButton>().interactable = makeInteractable;
            calibrationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            validationButton.GetComponent<LeanButton>().interactable = makeInteractable;
            endExpButton.GetComponent<LeanButton>().interactable = makeInteractable;
        }
        
    }
    // End experiment button
    public void EndExperiment()
    {
        // Are you sure stuff and data saving 
    }
    
    
}
