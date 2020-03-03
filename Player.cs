using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public Player()

    {

        arrows = 5;

        coins = 150;

        turns = 0;

    }



    public bool useArrow()

    {

        if (arrows >= 1)

        {

            arrows -= 1;

            return true;

        }
        else

        {

            return false;

        }

    }
}
