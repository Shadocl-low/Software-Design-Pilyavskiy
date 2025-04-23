using Mediator;

namespace DesignPatterns.Mediator
{
    public class CommandCentre : ICommandCentre
    {
        private readonly Dictionary<Runway, Aircraft?> _runwayAssignments = new();

        public CommandCentre(List<Runway> runways)
        {
            foreach (var runway in runways)
            {
                _runwayAssignments[runway] = null;
            }
        }
        public void Notify(object sender, string ev)
        {
            if (sender is Aircraft aircraft)
            {
                switch (ev)
                {
                    case "land":
                        HandleLanding(aircraft);
                        break;
                    case "takeoff":
                        HandleTakeoff(aircraft);
                        break;
                }
            }
        }
        public void HandleLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
            Console.WriteLine($"Checking runways.");
            foreach (var kvp in _runwayAssignments)
            {
                if (kvp.Value == null)
                {
                    aircraft.IsTakingOff = false;
                    _runwayAssignments[kvp.Key] = aircraft;
                    kvp.Key.HighLightRed();
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {kvp.Key.Id}.\n");
                    return;
                }
            }
            Console.WriteLine($"Could not land, the runways are busy.\n");
        }

        public void HandleTakeoff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
            foreach (var kvp in _runwayAssignments)
            {
                if (kvp.Value == aircraft)
                {
                    aircraft.IsTakingOff = true;
                    _runwayAssignments[kvp.Key] = null;
                    kvp.Key.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {kvp.Key.Id}.\n");
                    return;
                }
            }
            Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to any runway.\n");
        }
    }
}