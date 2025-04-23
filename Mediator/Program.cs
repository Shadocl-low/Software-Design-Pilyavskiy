using DesignPatterns.Mediator;

List<Runway> runWays = new();
for (int i = 0; i < 4; i++)
{
    runWays.Add(new Runway());
}
var commandCentre = new CommandCentre(runWays);

var Boeing = new Aircraft("Boeing-747", commandCentre);
var Airbus = new Aircraft("Airbus-A320", commandCentre);
var Falcon = new Aircraft("Falcon-1", commandCentre);
var Eagle = new Aircraft("Eagle-2", commandCentre);
var Hawk = new Aircraft("Hawk-3", commandCentre);

Boeing.Land();
Airbus.Land();
Falcon.Land();
Eagle.Land();
Hawk.Land();

Eagle.TakeOff();
Falcon.TakeOff();
Hawk.Land();

