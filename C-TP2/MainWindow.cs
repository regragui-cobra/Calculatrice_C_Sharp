using System;
using System.Linq;
using Gtk;
using System.Data;
public partial class MainWindow : Gtk.Window

{
    private int state;
    private int state_;
    private int state_point;
    private string lastchar;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        state = 0;
        state_ = 0;
        state_point = 0;
        Build();
        
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnTogglebutton9Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "1";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "1";
        }
    }

    protected void OnTogglebutton8Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "2";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "2";
        }
    }

    protected void OnTogglebutton7Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "3";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "3";
        }
    }
    protected void OnTogglebutton2Clicked(object sender, EventArgs e)
    {
        state = 0;
        state_ = 0;
        state_point = 0;
        label1.Text = "";
    }

    protected void OnTogglebutton10Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "4";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "4";
        }
    }

    protected void OnTogglebutton11Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "5";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "5";
        }
    }

    protected void OnTogglebutton12Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "6";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "6";
        }
    }

    protected void OnTogglebutton21Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "7";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "7";
        }
    }

    protected void OnTogglebutton18Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "8";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "8";
        }
    }

    protected void OnTogglebutton17Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "9";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "9";
        }
    }

    protected void OnTogglebutton19Clicked(object sender, EventArgs e)
    {
        if (state == 0)
        {
            label1.Text += "0";
        }
        else
        {
            OnTogglebutton2Clicked(new object(), new EventArgs());
            label1.Text += "0";
        }
    }

    protected void OnTogglebutton14Clicked(object sender, EventArgs e)
    {
        //TODO: gerer les exception suivant la fonction d'evaluation
        if (state == 0)
        {
            String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "(", ")" };
            String[] symbols = { ".", "(" };
            if (label1.Text.Length != 0) { lastchar = label1.Text.Substring(label1.Text.Length - 1); }
            else { lastchar = " "; }
            if (state_point == 0)
            {
                if (state_ == 0 && !nums.Contains(lastchar))
                {

                    label1.Text += "(";
                    state_ = 1;
                    state_point = 0;

                }
                else
                {
                    if (state_ != 0 && !symbols.Contains(lastchar))
                    {

                        label1.Text += ")";
                        state_ = 0;
                        state_point = 0;
                    }
                }
            }
        }
    }

    protected void OnTogglebutton16Clicked(object sender, EventArgs e)
    {
        if (label1.Text.Length != 0)
        {
            if (label1.Text.Substring(label1.Text.Length - 1) == ".")
            {
                state_point = 0;
            }
            if (label1.Text.Substring(label1.Text.Length - 1) == "(")
            {
                state_ = 0;
            }
            if (label1.Text.Substring(label1.Text.Length - 1) == ")")
            {
                state_ = 1;
            }
            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }
    }

    protected void OnTogglebutton3Clicked(object sender, EventArgs e)
    {

        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ")" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar))
            {
                label1.Text += "/";
                state_point = 0;
            }
        }
    }

    protected void OnTogglebutton20Clicked(object sender, EventArgs e)
    {
        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar) && state_point == 0)
            {
                label1.Text += ".";
                state_point = 1;
            }
        }
    }

    protected void OnTogglebutton4Clicked(object sender, EventArgs e)
    {
        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ")" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar))
            {
                label1.Text += "%";
                state_point = 0;
            }
        }
    }

    protected void OnTogglebutton5Clicked(object sender, EventArgs e)
    {
        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ")" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar))
            {
                label1.Text += "*";
                state_point = 0;
            }
        }
    }

    protected void OnTogglebutton6Clicked(object sender, EventArgs e)
    {
        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ")" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar))
            {
                label1.Text += "-";
                state_point = 0;
            }
        }
    }

    protected void OnTogglebutton13Clicked(object sender, EventArgs e)
    {
        String[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ")" };
        if (label1.Text.Length != 0)
        {
            lastchar = label1.Text.Substring(label1.Text.Length - 1);
            if (nums.Contains(lastchar))
            {
                label1.Text += "+";
                state_point = 0;
            }
        }
    }

    protected void OnTogglebutton15Clicked(object sender, EventArgs e)
    {
        try
        {
            label1.Text = new DataTable().Compute(label1.Text, null).ToString();
        }
        catch
        {
            label1.Text = "Erreur";
        }
        state = 1;
    }
}
