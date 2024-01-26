using Runtime.Model.Player;
using Runtime.Signals;
using strange.extensions.command.impl;

namespace Runtime.Controller.PlayerControllers
{
    public class ManageStackCommand: Command
    {   
        
        [Inject] public IPlayerModel PlayerModel { get; set; }
        [Inject] public UISignals UISignals { get; set; }

        public override void Execute()
        {
            
        }
    }
}