using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequiredServicesWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void topTenWordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequiredServicesReference_v2.Service1Client myPxy = new RequiredServicesReference_v2.Service1Client();

                String userInput = myPxy.getStarted(topTenWordsUrlTextBox.Text);

                topTenLabel.Text = userInput;

                //topTenLabel.Text = TopTenWords.getStarted(topTenWordsUrlTextBox.Text);

                myPxy.Close();
            }
            catch (FormatException)
            {
                topTenLabel.Text = "Invalid User Input. ";
            }
        }

        protected void removeStopWordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequiredServicesReference_v2.Service1Client myPxy = new RequiredServicesReference_v2.Service1Client();

                String userInput = myPxy.WordFilter(removeStopWordsTextbox.Text);

                removedStopWordsLabel.Text = userInput;

                //removedStopWordsLabel.Text = RemoveStopWords.WordFilter(removeStopWordsTextbox.Text);

                myPxy.Close();
            }
            catch (FormatException)
            {
                removedStopWordsLabel.Text = "Invalid User Input. ";
            }
        }
    }
}