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
    public GameObject introImage, introImage2, introImage3; 
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
        homeButton.SetActive(true);
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Top;
        introText.text =  "\n\n\n\n\nWelcome To\n" + "The Solar System in VR!" ;
        expText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
        expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Top;
        expText.text = "\n\n\n\n\n\n\n\nLearn about space objects in our solar system through interactive journey!";
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
                introImage3.SetActive(false);
                introImage2.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
                homeButton.SetActive(true);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\n\n\n\nOverview";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Left;
                expText.text = "\n\n\n\nTitle: The Solar System in VR\n" +
                               "Platform: VR Devices\n" +
                               "Subject: Astronomy\n" +
                               "Sub Subject: The Solar System\n" +
                               "Main Focus: The Solar System Entities\n" +
                               "Learning Level: Grades 9-12"; 
                break;
            case 2:
                introImage2.SetActive(false);
                introImage3.SetActive(true);
                introImage3.GetComponent<Image>().color = new Color32(200, 200, 200, 255);
                //introImage3.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\n\n\n\nProposal";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "\n\n\n\n\n\nToday, many astronomy class textbooks contain incorrect illustrations of the Solar System due to limited space of the book pages. Unfortunately, this gives students false sense of scales and distances of the planets and other objects (moons, asteroids, comets etc.,). I propose to design an interactive simulated model of the Solar System in VR where students could experience the subject in several perspectives. This will allow students to have more accurate understanding measures of relatively small and enormous objects in the Solar System and overall, in cosmos.";
                break;
            case 3:
                introImage3.SetActive(true);
                introImage3.GetComponent<Image>().color = new Color32(200, 200, 200, 255);
                //introImage3.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\nCompeting Software Review\n\n\n\n\n\n\n\n";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "○ The Sky Live - the Solar System a web page interactive application. While providing good navigation tools the scale and distances between simulated objects are incorrect in The Sky  Live. \n\n" + 
                               "◙ Phrenopolis – another “the Solar System in a web page”. This source shows correct scale model of the Sun and planets. The planets are shown at their true-to-scale average distances from the Sun. Unfortunately, the website is confusing to experience the subject and involves “a lot” of scrolling. While being the largest web pages on the web it is not supported in all browsers.\n\n" + 
                               "☼ Our Solar System - VR simulation application, provides for 3+ ages the Solar System. Unfortunately, the VR simulation provides same approaches in visualization the subject as in traditional inaccurate way as it was reviewed in the proposal section.  Our Solar System application provides general understanding of the Solar System in very primitive approach: the objects and distances are incorrect. Poor quality of the content (low poly) and very limited UI, UX design. \n";
                break;
            case 4:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\nCompeting Software Suggested Improvements";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "● Gameplay and immersion - AR/VR interactives that allow the user to feel that he/she can experience the Solar System on a more accurate and in visually appealing level. \n\n"+
                               "● Engagement factors - More interactive ways to engage with the Solar System objects and getting information about the subjects within the simulation. \n\n" +
                               "● Better accessibility – Beside VR devices, users can access the simulation with their handheld devices (smartphones, tablets etc.,) connecting them to their PC for rendering purposes. \n";
                break;
            case 5:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\n\n\n\nStakeholders and Users";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "\n\n\n○ Teachers\n" + "○ Parents\n" + "○ Students\n\n" + "☺ Users: 9-12th Grade Students";
                break;
            case 6:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\nPersona ☺";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "Name: Jane\n" + 
                               "Age: 14 years old\n" + 
                               "Gender: Female\n" + 
                               "Location: Newark, NJ\n\n" +
                               
                               "Personal Notes: \n" + 
                               "    ○ Loves using handheld technologies (smartphones, tablets, etc.,)\n" + 
                               "    ○ Curios of new games and apps\n\n" +
                               
                               "Student Notes: \n" + 
                               "    ○ Struggles with understanding astronomy terms and scientific numbers.\n" + 
                               "    ○ Prefers a visual/kinesthetic way of learning. \n" +
                               "    ○ Retains information best when presented in a hands-on or visually";
                break;
            case 7:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\n\n\n\nPersona Justification";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "\n\n\nAfter meeting with stakeholders and gathering information during the initial research phase, we settled on a persona named Jane. She represents the users of this educational application; a middle school student who needs more creative ways to learn concepts that are not familiar to her. ";
                break;
            case 8:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\nProblem Scenario ";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "First, Jane was excited with her 9th grade Astronomy class but after couple classes it started becoming complicated. Jane has always been very active and social. She learns best by doing a task, rather than listening to directions. Moreover, Jane experienced many interactive applications and games on her tablet. After going through visual cues of an application Jane quickly learns how to navigate withing the app and perform a certain task. Jane finds this interactive process as a fun activity as she learns new things visually and effortlessly. During the school year, the ability to actively participate in class lessons has been limited since the curriculum has become more abstract and complicated than she is used to. Although, there are colorful images of various space objects in her Astronomy textbook, Jane is still struggling on understanding the big numbers and scales that come with those images. She is assigned some word and comparison problems in her textbook but cannot concentrate so she decides to slip out of class and play with another group of students or play games on her tablet during their recess at school.";
                break;
            case 9:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\nProblem Scenario (continued)";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "After a while, the teacher notices Jane is not paying attention when teacher talks about scales and big numbers related to the class topic. The teacher sees her talking to other classmates about images in her Astronomy textbook. Jane becomes confused and hesitant when she asked about order of the planets in the Solar system and scales of the planets. She ends up getting frustrated and does not consider spending more time on learning Astronomy.";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\nActivity Scenario ";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "The next class, Jane’s Astronomy teacher tells the class that they will go to the lab and look at the solar system through interactive space simulation using VR.  Jane becomes excited as she heard about VR devices, but she never used one before.\n\n" + "After Jane has been playing the simulation for couple classes, she understood some topics that she did not understanding reading her textbook. The virtual 3D models of space objects helped her understand their scales. For example, Jane saw a cut scene in the simulation (during which she was asked to stand still by the narrator in the simulation) how 1.3 million tiny Earths with radius of 6,371 km can fit into the enormous boiling and shinning Sun with radius of 1.3927 million km. Using VR joysticks Jane flew (386,400 kilometers with various speeds in 2 min) in a spaceship to the Moon. Jane also found out that it took longer to “fly” to Mars from Earth.\n\n" + "After Lab classes, Jane becomes interested in learning more about the solar system and Astronomy in general" ;
                break;
            case 11:
                nextButton.SetActive(false);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "\n\n\n\nProblem Statement";
                expText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                expText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Justified;
                expText.text = "Jane is frustrated with the numerous new information and assignments in her Astronomy class. She is an active person, user and prefers to learn with visual and physical aids. She needs a way to relate to the material in her Astronomy class, where they are learning about the solar system. She needs to understand the importance of Astronomy to today’s knowledge-based society and how knowledge from Astronomy can help her better understand our planet. Jane learns and understands more Astronomy topics using interactive space simulation in VR.  ";
                
                break;
                
        }
    }
    
}
