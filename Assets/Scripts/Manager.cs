using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Cairney_Daniel
{

    public class Manager : MonoBehaviour
    {
        public Text Result;
        public Image AIChoice;

        public string[] Choices;
        public Sprite EnmaHigh, EnmaMedium, EnmaLow;


        public void Play(string myChoice)
        {
            string randomChoice = Choices[Random.Range(0, Choices.Length)];

            switch (randomChoice)
            {
                case "High":
                    switch (myChoice)
                    {
                        case "High":
                            Result.text = "Parry";
                            
                            break;

                        case "Medium":
                            Result.text = "You got hit";
                            
                            break;

                        case "Low":
                            Result.text = "Hit";
                            
                            break;
                    }

                    AIChoice.sprite = EnmaHigh;
                    break;
                
                case "Medium":
                    switch (myChoice)
                    {
                        case "High":
                            Result.text = "Hit";
                           
                            break;

                        case "Medium":
                            Result.text = "Parry";
                           
                            break;

                        case "Low":
                            Result.text = "You got hit";
                            
                            break;
                    }
                    AIChoice.sprite = EnmaMedium;
                    break;

                case "Low":
                    switch (myChoice)
                    {
                        case "High":
                            Result.text = "You got hit";
                         
                            break;

                        case "Medium":
                            Result.text = "Hit";
                            
                            break;

                        case "Low":
                            Result.text = "Parry";
                           
                            break;
                    }
                    AIChoice.sprite = EnmaLow;
                    break;
            }

        }
    }


   
    


}