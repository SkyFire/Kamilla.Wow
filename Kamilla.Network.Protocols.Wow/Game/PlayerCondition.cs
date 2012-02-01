using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    /// <summary>
    /// Data from PlayerCondition.dbc.
    /// </summary>
    public enum PlayerCondition
    {
        [LocalizedName("Must complete quest 'Bounty on Murlocs'")]
        BountyOnMurlocs = 9414,
        [LocalizedName("Must have completed \"Filling the Moonwell\".")]
        FillingTheMoonwell = 12161,
        [LocalizedName("Must have completed \"Calling the Ancients\".")]
        CallingTheAncients = 12163,
        [LocalizedName("Must have completed \"Additional Armaments\".")]
        AdditionalArnaments = 12212,
        [LocalizedName("Must have completed \"Filling the Moonwell\", \"Additional Armaments\" and \"Calling the Ancients\".")]
        FillingTheMoonwell_AdditionalArnaments_CallingTheAncients = 12380,
        [LocalizedName("Must have completed \"Through the Gates of Hell\".")]
        ThroughTheGatesOfHell = 12515,
    }
}
