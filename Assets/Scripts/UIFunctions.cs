using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public TMP_Text introText, expText;
    public GameObject introImage, introImage2;
    public GameObject homeButton, backButton, nextButton;
    
    
    private Scene _currentScene;
    private int _introSequence;
    private void Awake()
    {
        _currentScene = SceneManager.GetActiveScene();
        switch (_currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                InitializeIntro();
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void InitializeIntro()
    {
        introImage.SetActive(true);
        introImage2.SetActive(false);
        backButton.SetActive(false);
        nextButton.SetActive(true);
        homeButton.SetActive(false);
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "Welcome To" + "The Solar System in VR!";
        expText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        expText.text = "Learn about space objects in our solar system through interactive journey!";
        introImage.SetActive(true);
        introImage.transform.GetComponent<Image>().color = new Color32(70,70,70, 255);
        backButton.SetActive(false);
    }

    public void IntroSequenceBack()
    {
        _introSequence--;
        SetIntroSequence();
    }

    public void IntroSequenceNext()
    {
        _introSequence++;
        SetIntroSequence();
    }
    
    void SetIntroSequence()
    {
        switch (_introSequence)
        {
            case 0:
                InitializeIntro();
                break;
            case 1:
                introImage.SetActive(false);
                introImage2.SetActive(true);
                introImage2.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
                homeButton.SetActive(true);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\nOverview";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.text = "Title: The Solar System in VR\n" +
                               "Platform: VR Devices\n" +
                               "Subject: Astronomy\n" +
                               "Sub Subject: The Solar System\n" +
                               "Main Focus: The Solar System Entities\n" +
                               "Learning Level: Grades 9-12"; 
                break;
        }
    }
    
}
