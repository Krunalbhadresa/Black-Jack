using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void deal_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();

        int card1 = rnd.Next(1,11);
        c1.Text = Convert.ToString(card1);

        int card2 = rnd.Next(1, 11);
        c2.Text = Convert.ToString(card2);

        utotal.Text = "Total :";
        uscore.Text = Convert.ToString(card1 + card2);

        deal.Enabled = false;
        
    }

    protected void hit_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        int hcard = rnd.Next(1, 11);
        hc.Text = Convert.ToString(hcard);

        uscore.Text = Convert.ToString(Convert.ToInt32(uscore.Text) + Convert.ToInt32(hc.Text)) ;
        if(Convert.ToInt32(uscore.Text) > 21)
        {
            result.Text = "Sorry, You lost !!";
            deal.Enabled = false;
            hit.Enabled = false;
            pass.Enabled = false;
        }
    }


    protected void pass_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        int d1 = rnd.Next(1, 11);
        int d2 = rnd.Next(1, 11);
        dscore.Text = Convert.ToString(d1 + d2);
        dtotal.Text = "Dealer's score :";

        do
        {
            int d3 = rnd.Next(1, 11);
            dscore.Text = Convert.ToString(Convert.ToInt32(dscore.Text) + d3);
        } while (Convert.ToInt32(dscore.Text) < 17);

        if (Convert.ToInt32(dscore.Text) >= 17 && Convert.ToInt32(dscore.Text) < 21)
        {
            if (Convert.ToInt32(uscore.Text) >= Convert.ToInt32(dscore.Text))
            {
                result.Text = "Congratulations, You won !!";
            }
            else
            {
                result.Text = "Sorry, You lost !!";
            }
        }
        else
        {
            result.Text = "Congratulations, You won !!";
        }
        hit.Enabled = false;
        pass.Enabled = false;

    }

    protected void restart_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
        c1.Text = "";
        c2.Text = "";
        hc.Text = "";
        utotal.Text = "";
        uscore.Text = "";
        dtotal.Text = "";
        dscore.Text = "";
        result.Text = "";
        deal.Enabled = true;
        hit.Enabled = true;
        pass.Enabled = true;
    }
}