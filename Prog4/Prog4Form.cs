// Program 4
// By: Richard Patrick
// Due: 4/24/16
// Section: CIS199-01
// Description: This program allows the user to enter details about a package, valdates entry,
// then creates an object based on the details. It allows the user to view the details and calculates
// the price in a list box. It also allows you to send the package to or from UofL by changing the zip codes.
// It uses the GroundPackage class to test and get the data.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Prog4Form : Form
    {
        List<GroundPackage> packageList = new List<GroundPackage>(); // List to hold GroundPackage object

        public Prog4Form()
        {
            InitializeComponent();
        }
        // Precondition:  User clicked on Add Ground Package button
        // Postcondition: If user's input is valid, the ground package object is made with the specified values,
        //                and added to list, otherwise an error messeage is displayed to the user.
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            int orginZip;  // OrginZip value to set
            int destZip;   // DestinationZip value to set
            double length; // Length value to set
            double width;  // Width value to set
            double height; // Height value to set
            double weight; // Weight value to set
           
            if (int.TryParse(orginTextBox.Text, out orginZip))  // If valid int
            {

                if (int.TryParse(destTextBox.Text, out destZip)) // If valid int
                {

                    if (double.TryParse(lengthTextBox.Text, out length)) // If valid double
                    {

                        if (double.TryParse(widthTextBox.Text, out width)) // If valid double
                        {

                            if (double.TryParse(heightTextBox.Text, out height)) // If valid double
                            {

                                if (double.TryParse(weightTextBox.Text, out weight)) // If valid double
                                {
                                    GroundPackage myPackage =           // create object from GroundPackage class and set with values user entered
                                        new GroundPackage(orginZip,destZip, length, width, height, weight);
                                    myPackage.OrginZip = orginZip;      // Use OrginZip property to set value
                                    myPackage.DestinationZip = destZip; // Use DestinationZip property to set value
                                    myPackage.Length = length;          // Use length property to set value
                                    myPackage.Width = width;            // Use width property to set value
                                    myPackage.Height = height;          // Use height property to set value
                                    myPackage.Weight = weight;          // Use weight property to set value
                                    
                                    packageList.Add(myPackage); // Add object to list 
                                    
                                    packageListBox.Items.Add(myPackage.CalcCost().ToString("c")); // Add the calculated price from the object details
                                                                                                  // into the listBox

                                    orginTextBox.Clear();  // Clear orginTextBox for user
                                    destTextBox.Clear();   // Clear destTextBox for user
                                    lengthTextBox.Clear(); // Clear lengthTextBox for user
                                    widthTextBox.Clear();  // Clear widthTextBox for user
                                    heightTextBox.Clear(); // Clear heightTextBox for user
                                    weightTextBox.Clear(); // Clear weightTextBox for user

                                    orginTextBox.Focus(); // Put focus in first textBox
                                }
                                else // If unvalid data entered
                                {
                                    MessageBox.Show("Please enter valid Weight"); // Display error message
                                }
                            }
                            else // If unvalid data entered
                            {
                                MessageBox.Show("Please enter valid Height"); // Display error message
                            }
                        }
                        else // If unvalid data entered
                        {
                            MessageBox.Show("Please enter valid Width"); // Display error message
                        }
                    }
                    else // If unvalid data entered
                    {
                        MessageBox.Show("Please enter valid Length"); // Display error message
                    }
                }
                else // If unvalid data entered
                {
                    MessageBox.Show("Please enter valid Destination Zip"); // Display error message
                }
            }
            else // If unvalid data entered
            {
                MessageBox.Show("Please enter valid Orgin Zip"); // Display error message
            }
        }
        // Precondition:  User clicked on Details button
        // Postcondition: If user's selcets item from listBox return details in message box
        //                otherwise return error message
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index; // Create varaible index to go through list  
            index=packageListBox.SelectedIndex; // index equals the price position the user selected in the listBox
            if(index>=0) // if selected
            {
                MessageBox.Show(packageList[index].ToString()); // Show the objects details in the ToString format
            }
            else // if not selected
            {
                MessageBox.Show("Please Select Item from ListBox"); // Show error
            }
        }
        // Precondition:  User clicked on Send to UofL button
        // Postcondition: If user's selcets item from listBox returns new zip code in details, new price in listBox
        //                and displays message saying zip has been reset in a message box
        //                otherwise return error message
        private void sendToButton_Click(object sender, EventArgs e)
        {
            int index;                            // Create varaible index to go through list
            const int UNIVERSITY_ZIP = 40292;     // create constant for University zip code
            double cost;                          // variable to hold new cost
            index = packageListBox.SelectedIndex; // index equals the price position the user selected in the listBox
            
            if (index >= 0)  // If selected 
            {
                packageList[index].DestinationZip = UNIVERSITY_ZIP;     // Get the selected item's index from list and set new zip
                cost = packageList[index].CalcCost();             // Set cost equal to new cost caluculated with new zip
                packageListBox.Items[index] = cost.ToString("c"); // Put the new cost in place of old cost and format as currency

                MessageBox.Show("The specified package Destination Zip has been reset"); // Show message that zip has been reset
            }
            else // If not selected
            {
                MessageBox.Show("Please Select Item from ListBox"); // Show error
                
            } 

        }
        // Precondition:  User clicked on Send From UofL button
        // Postcondition: If user's selcets item from listBox returns new zip code in details, new price in listBox
        //                and displays message saying zip has been reset in a message box
        //                otherwise return error message
        private void sendFromButton_Click(object sender, EventArgs e)
        {
            int index;                            // Create varaible index to go through list
            const int UNIVERSITY_ZIP = 40292;     // create constant for University zip code
            double cost;                          // variable to hold new cost
            index = packageListBox.SelectedIndex; // index equals the price position the user selected in the listBox
            
            if (index >= 0) // If selected
            {
                packageList[index].OrginZip = UNIVERSITY_ZIP;     // Get the selected item's index from list and set new zip
                cost = packageList[index].CalcCost();             // Set cost equal to new cost caluculated with new zip
                packageListBox.Items[index] = cost.ToString("c"); // Put the new cost in place of old cost and format as currency
                MessageBox.Show("The specified package Orgin Zip has been reset"); // Show message that zip has been reset
            }
            else  // If not selected
            {
                MessageBox.Show("Please Select Item from ListBox"); // Show error
                
            } 
        }
    }
}
