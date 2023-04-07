using UnityEngine;

namespace Bardent.FSM
{
    public class PlayerStunState : PlayerState
    {
        private Movement movement;
        private Movement Movement => movement ? movement : core.GetCoreComponent(ref movement);
        
        public PlayerStunState(Player player, PlayerStateMachine stateMachine, PlayerData playerData,
            string animBoolName) : base(player, stateMachine, playerData, animBoolName)
        {
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            
            Movement.SetVelocityX(0f);

            if (Time.time >= startTime + playerData.stunTime)
            {
                stateMachine.ChangeState(player.IdleState);
            }
        }
    }
}