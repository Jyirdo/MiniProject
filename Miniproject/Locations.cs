// public int ID;
// public string Name;
// public string Description;
// public Quest QuestAvailableHere;
// public Monster MonsterLivingHere;
// public Location LocationToNorth;
// public Location LocationToEast;
// public Location LocationToSouth;
// public Location LocationToWest;
class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest? QuestAvailableHere;
    public Monster? MonsterLivingHere;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;

    public Location(int id, string name, string description, Quest? questavailablehere, Monster? monsterlivinghere)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = questavailablehere;
        MonsterLivingHere = monsterlivinghere;
    }


    //LOCATION_ID_HOME = 1;
    //LOCATION_ID_TOWN_SQUARE = 2;
    //LOCATION_ID_GUARD_POST = 3;
    //LOCATION_ID_ALCHEMIST_HUT = 4;
    //LOCATION_ID_ALCHEMISTS_GARDEN = 5;
    //LOCATION_ID_FARMHOUSE = 6;
    //LOCATION_ID_FARM_FIELD = 7;
    //LOCATION_ID_BRIDGE = 8;
    //LOCATION_ID_SPIDER_FIELD = 9;

}


// https://hrnl.sharepoint.com/:p:/r/sites/CMI-INF1E-2324OP34-OODPProjectBSLC2/Shared%20Documents/Project%20B/Mini%20project%20(week%202-3)/Week%202/Mini%20project/Mini%20Project%20Introduction.pptx?d=w7f4b944498a94b3596d88117ba22b6a2&csf=1&web=1&e=MrFAZc
// Legend:​
// H: Your house (game start)​
// T: Town square​
// F: Farmer​
// V: Farmer’s field​
// A: Alchemist’s hut​
// P: Alchemist’s garden​
// G: Guard post​
// B: Bridge​
// S: Spider forest​

// Map als in powerpoint:
//   P​
//   A​
// VFTGBS​
//   H​

