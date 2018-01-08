using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour {

    private bool topLeft;
    private bool topRight;
    private bool bottomLeft;
    private bool bottomRight;

    // Use this for initialization
    void Start () {
        this.topLeft = true;
        this.topRight = false;
        this.bottomLeft = false;
        this.bottomRight = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.topRight)
            {
                this.topRight = false;
                this.topLeft = true;
            }
            else if (this.bottomRight)
            {
                this.bottomRight = false;
                this.bottomLeft = true;
            }
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.topLeft)
            {
                this.topLeft = false;
                this.topRight = true;
            }
            else if (this.bottomLeft)
            {
                this.bottomLeft = false;
                this.bottomRight = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (this.topLeft)
            {
                this.topLeft = false;
                this.bottomLeft = true;
            }
            else if (this.topRight)
            {
                this.topRight = false;
                this.bottomRight = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (this.bottomLeft)
            {
                this.bottomLeft = false;
                this.topLeft = true;
            }
            else if (this.bottomRight)
            {
                this.bottomRight = false;
                this.topRight = true;
            }
        }
        this.setSelectionImage();
    }

    private void setSelectionImage()
    {
        GameObject img = this.gameObject.transform.GetChild(0).gameObject;
        if (this.name == "Fight" && this.topLeft)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (this.name == "Fight")
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        if (this.name == "Bag" && this.topRight)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (this.name == "Bag")
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        if (this.name == "Pokemon" && this.bottomLeft)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (this.name == "Pokemon")
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        if (this.name == "Run" && this.bottomRight)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (this.name == "Run")
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
