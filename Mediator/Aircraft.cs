using Mediator;

namespace DesignPatterns.Mediator
{
  public class  Aircraft
  {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private readonly ICommandCentre _commandCentre;

        public Aircraft(string name, ICommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
        }
        public void Land()
        {
            _commandCentre.Notify(this, "land");
        }

        public void TakeOff()
        {
            _commandCentre.Notify(this, "takeoff");
        }
    }
}