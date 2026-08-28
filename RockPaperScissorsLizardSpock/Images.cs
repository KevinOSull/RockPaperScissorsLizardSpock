using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Images
    {
        public static Image[] gameImages =
        {
            Image.FromFile("Resources/rock.jpg"),
            Image.FromFile("Resources/paper.jpg"),
            Image.FromFile("Resources/scissors.jpg"),
            Image.FromFile("Resources/lizard.png"),
            Image.FromFile("Resources/spock.png")
        };
    }
}
