using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;

public class GlobalScript : MonoBehaviour
{
    public GameObject welcomeCanvas, electronicsCanvas, mechanicalCanvas, chemicalCanvas, specialCanvas, infoCanvas;

    public void electronicsButton()
    {
        welcomeCanvas.SetActive(false);
        electronicsCanvas.SetActive(true);
    }

    public void mechanicalButton()
    {
        welcomeCanvas.SetActive(false);
        mechanicalCanvas.SetActive(true);
    }

    public void chemicalButton()
    {
        welcomeCanvas.SetActive(false);
        chemicalCanvas.SetActive(true);
    }

    public void specialButton()
    {
        welcomeCanvas.SetActive(false);
        specialCanvas.SetActive(true);
    }

    public void gobackButton()
    {
        welcomeCanvas.SetActive(true);
        electronicsCanvas.SetActive(false);
        mechanicalCanvas.SetActive(false);
        chemicalCanvas.SetActive(false);
        specialCanvas.SetActive(false);
    }

    public void showInfo()
    {
        infoCanvas.SetActive(true);
        GameObject buttonClicked = EventSystem.current.currentSelectedGameObject;
        // Debug.Log(buttonClicked);
        // userChoice = buttonClicked.name;

        /// ECE
        if(buttonClicked.name == "ArduinoIR")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Arduino IR Sensor";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "This module simulates the use of an IR sensor interfaced with an Arduino. Users can calibrate the IR sensor manually, i.e. threshold distance and color and intensity of LEDs. As the mobile device moves closer to the sensor the device will light-up.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/arduino_ir");
            // userChoice = "alu";
        }

        else if(buttonClicked.name == "TemperatureSensors")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Temperature Sensors";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Various temperature sensors are available in the market. This package gives users an option to simulate RTD (Pt, Ni, Cu), Thermistor(Feo, Mn, Ti), and Thermocouple(J, K). An apparatus is provided to change input parameters and observe the graph on a digital screen.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/temperature_sensors");
        }

        else if(buttonClicked.name == "Oscilloscope")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Oscilloscope Sine Wave Generator";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Digital Oscilloscope is a device used to observe input and output waveforms in a circuit. The given experiment enables users to generate a Sine wave from the circuit and observe it on the oscilloscope. Wave modification components - shifting and scaling -  are also available within the package. Output frequency and voltage can also be altered.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/oscilloscope");
        }

        /// Mech
        else if(buttonClicked.name == "DrillingMachine")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Drilling Machine";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "This machine is used as a helping tool in mechanical workshops to cut holes of varying sizes. The selected package equips the user with a completely dynamic operation of the same, giving an immersive lifelike experience.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/drilling_machine");
        }

        else if(buttonClicked.name == "LatheMachine")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Lathe Machine";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Lathe machine is a mechanical workshop machine tool which performs various modification a fast-rotating metal piece. This module is capable of cutting, sanding, knurling, drilling, deformation, facing, and turning of the metal piece. All the handles and wheels can be controlled manually.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/lathe_machine");
        }

        else if(buttonClicked.name == "RollingMachine")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Plate Rolling Machine";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Rolling Machine is useful in mechanical industry applications where a sheet has to be converted into a cylinder or a cone. This module simulates the functioning of this machine. Users can set the target radius of the cylinder beforehand.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/rolling_machine");
        }

        else if(buttonClicked.name == "MillingMachine")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Vertical Milling Machine";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "The milling machine comes handy in the applications where small grooves are to be cut into a metal piece along with the shining of surfaces. The operation of this heavy machinery is engulfed in this package. It is equipped with all the essential levers and handles giving complete control to the user.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/milling_machine");
        }

        /// Chemical
        else if(buttonClicked.name == "Titration")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Titration";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Titration is a chemical process for quantitative analysis. This module is a collection of step-by-step instructions for the complete process of KMnO4 and Oxalic Acid Titration. Users can also modify the weights and volumes of required chemicals.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/titration");
        }

        /// Special
        else if(buttonClicked.name == "JCBBackHoe")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "JCB Backhoe";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "JCB Backhoe tractor is one of the essential parts of construction industry. This package provides a completely dynamic simulation of the same. All the handles and levers can be controlled by the user to gain a completely immersive experience.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/jcb_backhoe");
        }
        else if(buttonClicked.name == "NewtonCradle")
        {
            infoCanvas.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = "Newton's Cradle";
            infoCanvas.transform.Find("Content").GetComponent<TextMeshProUGUI>().text = "Newton Cradle is a perfect demonstration of the concept of ‘Conservation of Momentum’. Since it is not available remotely, this module will allow students to visualize the concept. It is well equipped with all the features required.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Textures/newton_cradle");
        }
    }

    public void closeInfoCanvas()
    {
        infoCanvas.SetActive(false);
    }

}