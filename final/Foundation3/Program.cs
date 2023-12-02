using System;

class Program
{
    static void Main(string[] args)
    {
        //Instances of LectureEvent
        Address lecture = new Address("201 President's Cir", "Anywhere", "Utah");
        LectureEvent standardLec = new LectureEvent("Mind Mapping and Brain Expansion", "This lecture will change your view and expand your mind to the science of brain mapping.", "December 14, 2025", "7:00p.m. to 9:00p.m.", lecture);
        LectureEvent fullDetailsLec = new LectureEvent("Mind Mapping and Brain Expansion", "Dr. Joan Mindly MD, PHD", "This lecture will change your view and expand your mind to the science of brain mapping.", 150, "December 14, 2025", "7:00p.m. to 9:00p.m.", lecture);
        LectureEvent shortMessageLec = new LectureEvent("Mind Mapping and Brain Expansion", "December 14, 2025");

        //Method calls of LectureEvent
        Console.WriteLine("");
        standardLec.DisplayStandardMessage();
        Console.WriteLine("");
        Console.WriteLine(fullDetailsLec.DisplayFullDetails());
        Console.WriteLine("");
        shortMessageLec.DisplayShortMessage();
        Console.WriteLine("");

        //Instances of ReceptionEvent
        Address reception = new Address("123 N Alabama Rd", "USA city", "Maine");
        ReceptionEvent standardRec = new ReceptionEvent("Jones Wedding", "Dale and Emily Jones Wedding and Reception", "April 14, 2024", "6:00p.m. to 8:00p.m.", reception);
        ReceptionEvent fullDetailsRec = new ReceptionEvent("Jones Wedding", "Dale and Emily Jones Wedding and Reception", "April 14, 2024", "6:00p.m. to 8:00p.m.",reception, "jonesreception@someemail.com");
        ReceptionEvent shortMessageRec = new ReceptionEvent("Jones Wedding", "April 14, 2024");

        //Method calls for ReceptionEvent
        standardRec.DisplayStandardMessage();
        Console.WriteLine("");
        Console.WriteLine(fullDetailsRec.DisplayFullDetails());
        Console.WriteLine("");
        shortMessageRec.DisplayShortMessage();
        Console.WriteLine("");

        //Instance of OutdoorGatheringEvent
        Address gathering =  new Address("576 S 3450 E", "Boise", "Idaho");
        OutdoorGatheringEvent standardOut = new OutdoorGatheringEvent("Basque Games", "Features: Harri jasotzea (Stone Lifting),\nAizkolaritza (Wood Chopping) and a Pelota tournament.", "July 15, 2025", "10:00a.m. to 2:00p.m.", gathering);
        OutdoorGatheringEvent fullDetailsOut = new OutdoorGatheringEvent("Basque Games", "Features: Harri jasotzea (Stone Lifting),\nAizkolaritza (Wood Chopping) and a Pelota tournament.", "July 15, 2025", "10:00a.m. to 2:00p.m.", "The weather outlook for the event: Partly cloudy, 75 degrees",gathering);
        OutdoorGatheringEvent shortOut = new OutdoorGatheringEvent("Basque Games", "July 15, 2025");

        //Method calls for OutdoorGatheringEvent
        standardOut.DisplayStandardMessage();
        Console.WriteLine("");
        Console.WriteLine(fullDetailsOut.DisplayFullDetails());
        Console.WriteLine("");
        shortOut.DisplayShortMessage();
        Console.WriteLine("");
      
        
    }
}