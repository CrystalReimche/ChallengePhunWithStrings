using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* ========================================================== 
         * 1. Reverse your name
         * ======================================================= */
        string myName = "Crystal Reimche";
        string myNameResult = "";   // This will hold the new end string
        for (int i = myName.Length - 1; i >= 0; i--)    // This will iterate over each character in the string, 
        {                                               // from back to front, and place each character into new string
            myNameResult += myName[i];
        }

        rLabel.Text = myNameResult;

        // When you're finished, it should look like this:
        // "ehcmieR latsyrC"




        /* ========================================================== 
         * 2. Reverse this sequence
         * ======================================================= */
        string names = "Luke,Leia,Han,Chewbacca";
        string[] namesArray = names.Split(',');
        string namesResult = "";

        Array.Reverse(namesArray);  // Reverse the words after split

        for (int i = 0; i <= namesArray.Length - 1; i++)    // Iterate over new array and display in order
        {
            namesResult += namesArray[i] + ",";
        }

        namesResult = namesResult.Remove(namesResult.Length - 1, 1);    // Remove the comma at the end of the string

        rLabel.Text = namesResult;

        // When you're finished, it should look like this:
        // Chewbacca,Han,Leia,Luke




        /* ========================================================== 
         * 3. Use the sequence to create ascii art:
         * ======================================================= */
        string moreNames = "Luke,Leia,Han,Chewbacca";
        string moreNamesResult = "";
        string[] moreNamesArray = moreNames.Split(',');

        for (int i = 0; i < moreNamesArray.Length; i++)
        {
            int padLeft = (14 - moreNamesArray[i].Length) / 2;  // There's 14 characters in the final product, subtract each name's length and divide remaining amount in half
            string temp = moreNamesArray[i].PadLeft(moreNamesArray[i].Length + padLeft, '*');
            moreNamesResult += temp.PadRight(14, '*');
            moreNamesResult += "<br>";
        }

        rLabel.Text = moreNamesResult;

        // When you're finished, it should look like this:
        // *****Luke*****
        // *****Leia*****
        // *****Han******
        // **Chewbacca***




        /* ========================================================== 
            * 4. Solve this puzzle
            * ======================================================= */
        string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO ZHE AID OF ZHEIR COUNZRY.";
        string endResult = "";
        string replace = puzzle.Replace("Z", "T");
        string lower = replace.ToLower();
        int index = lower.IndexOf("remove-me");
        string remove = lower.ToString().Remove(index, 9);

        if (remove.Length > 1)
        {
             endResult = char.ToUpper(remove[0]) + remove.Substring(1);
        }


        rLabel.Text = endResult;


        // When you're finished, it should look like this:
        // Now is the time for all good men to come to the aid of their country.












    }
}
 