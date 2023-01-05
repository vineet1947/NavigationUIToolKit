using UnityEngine;
using UnityEngine.UIElements;

public class PanelManager : MonoBehaviour
{
    public UIDocument Document;

    //bool setB = true;
    //bool setbutton = true;
    //bool activateSettingPage = true;

    private void Awake()
    {

        VisualElement root = Document.rootVisualElement; 
        // button for nav bar
        var homeButton = root.Q<Button>("homebutton");
        var profileButton = root.Q<Button>("profilebutton");
        var offerButton = root.Q<Button>("offersbutton");

        // 3 screens for display

        VisualElement homeScreen = root.Q<VisualElement>("home");
        VisualElement profileScreen = root.Q<VisualElement>("profile");
        VisualElement offerScreen = root.Q<VisualElement>("offers");

        homeButton.clicked += HomeButton_clicked;
        profileButton.clicked += ProfileButton_clicked;
        offerButton.clicked += OfferButton_clicked;


         void HomeButton_clicked()
        {
            Debug.Log("Home button Clicked !!");
            homeScreen.style.display = DisplayStyle.Flex; 
            profileScreen.style.display = DisplayStyle.None; 
            offerScreen.style.display = DisplayStyle.None;

        }


        void ProfileButton_clicked()
        {
            Debug.Log("Profile button Clicked !!");
            homeScreen.style.display = DisplayStyle.None;
            profileScreen.style.display = DisplayStyle.Flex;
            offerScreen.style.display = DisplayStyle.None;
        }


        void OfferButton_clicked()
        {
            Debug.Log("Offer button Clicked !!");
            homeScreen.style.display = DisplayStyle.None;
            profileScreen.style.display = DisplayStyle.None;
            offerScreen.style.display = DisplayStyle.Flex;
        }



        //void Settings_clicked()
        //{
        //    if (activateSettingPage)
        //    {

        //        settingScreen.style.display = DisplayStyle.Flex;
        //        mainScreen.style.display = DisplayStyle.None;

        //        activateSettingPage = !activateSettingPage;

        //    }
        //    else
        //    {
        //        activateSettingPage = !activateSettingPage;
        //    }

        //}

        //void BackButton_clicked()
        //{
        //    mainScreen.style.display = DisplayStyle.Flex;
        //    settingScreen.style.display = DisplayStyle.None;
        //    activateSettingPage = !activateSettingPage;

        //    Debug.Log("Back Button Clicked !!");

        //}


        //void Start_clicked()
        //{
        //    if (setbutton)
        //    {
        //        settings.style.display = DisplayStyle.None;
        //        setbutton = !setbutton;


        //    }
        //    else
        //    {
        //        settings.style.display = DisplayStyle.Flex;
        //        setbutton = !setbutton;
        //    }

        //}


        //void ScreenA_onClick()
        //{

        //    if (setB)
        //    {
        //        screenB.style.display = DisplayStyle.None; // hide 
        //        setB = !setB;
        //    }
        //    else
        //    {
        //        screenB.style.display = DisplayStyle.Flex; // show  
        //        setB = !setB;
        //    }
        //} 




    }

 
}
