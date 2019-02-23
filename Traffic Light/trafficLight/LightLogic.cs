using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafficLight
{
    class LightLogic
    {
        private LightState currentLightState;

        public LightLogic()
        {
            this.currentLightState = LightState.OFF;
        }
        public LightState GetNextAutomaticState()
        {
            LightState nextState = currentLightState;
            switch (this.currentLightState)
            {
                case LightState.GREEN:
                    nextState = LightState.GREEN_ORANGE;
                    break;
                case LightState.GREEN_ORANGE:
                    nextState = LightState.RED;
                    break;
                case LightState.RED:
                    nextState = LightState.ORANGE_RED;
                    break;
                case LightState.ORANGE_RED:
                    nextState = LightState.GREEN;
                    break;
                default:
                    nextState = LightState.RED;
                    break;
            }
            this.currentLightState = nextState;
            return nextState;
        }
        public LightState PowerSaver()
        {
            LightState nextState;
            if (this.currentLightState == LightState.ORANGE)
            {
                nextState = LightState.OFF;
            }
            else
            {
                nextState = LightState.ORANGE;
            }
            this.currentLightState = nextState;
            return nextState;
        }
        public bool EqualsCurrentLightState(LightState desiredState)
        {
            return desiredState == this.currentLightState;
        }
        public LightState SetState(LightState requiredState)
        {
            this.currentLightState = requiredState;
            return requiredState;
        }
        public LightState GotoState(LightState requiredState)
        {
            LightState nextState;
            if (this.currentLightState == requiredState)
            {
                nextState = this.currentLightState;
            }
            else if (requiredState == LightState.ORANGE)
            {
                if (this.currentLightState > LightState.RED)
                {
                    nextState = LightState.RED;
                }
                else if (this.currentLightState == LightState.RED) {
                    nextState = LightState.ORANGE_RED;
                }
                else if (this.currentLightState == LightState.ORANGE_RED ||
                    this.currentLightState == LightState.GREEN_ORANGE)
                {
                    nextState = LightState.ORANGE;
                }
                else if (this.currentLightState == LightState.GREEN)
                {
                    nextState = LightState.GREEN_ORANGE;
                }
                else if (this.currentLightState == LightState.ORANGE && requiredState == LightState.RED)
                {
                    nextState = LightState.ORANGE_RED;
                }
                else if (this.currentLightState == LightState.ORANGE && requiredState == LightState.GREEN)
                {
                    nextState = LightState.GREEN_ORANGE;
                }
                else
                {
                    MessageBox.Show($"CurState: {this.currentLightState};; ReqState: {requiredState}");
                    throw new Exception($"Unhandled LightState: {requiredState}");
                }
            }
            else if (requiredState < this.currentLightState)
            {
                nextState = this.currentLightState - 2;
                if (this.currentLightState == LightState.ORANGE)
                {
                    nextState--;
                }
            }
            else if (requiredState > this.currentLightState)
            {
                nextState = this.currentLightState + 2;
                if (this.currentLightState == LightState.ORANGE)
                {
                    nextState++;
                }
            }
            else if (this.currentLightState > LightState.RED)
            {
                nextState = requiredState;
            }
            else
            {
                throw new Exception($"Unhandled LightState: {requiredState}");
            }
            if (this.currentLightState == LightState.GREEN_ORANGE && nextState == LightState.ORANGE_RED)
            {
                nextState = LightState.RED;
            }
            else if (this.currentLightState == LightState.ORANGE_RED && nextState == LightState.GREEN_ORANGE)
            {
                nextState = LightState.GREEN;
            }
            this.currentLightState = nextState;
            return nextState;
        }
        public LightState GetCurrentState()
        {
            return this.currentLightState;
        }
    }
}
